using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PateticoPractic
{
    public partial class ChangeParameter : Form
    {
        int ParID;
        // метод, который инициализирует все компоненты, расположенные на форме
        public ChangeParameter(int ID, string NamePar)
        {
            InitializeComponent();
            ParID = ID;
            txtForNamePar.Text = NamePar;
        }        

        //закрытие данной формы и переход на форму категорий товаров
        private void picArrawBack_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Parameters Parameters = new Parameters();
            Parameters.Visible = true;
            Parameters.ShowInTaskbar = true;
        }

        //изменение данных записи в таблице бд по заполненным полям и закрытие формы
        private void roundBtnChange_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    SqlCommand cmd_1 = conn.CreateCommand();
                    cmd.CommandText = "UPDATE [Parameters] SET parameter = @NamePar WHERE id_parameter = @ID";
                    cmd.Parameters.AddWithValue(@"ID", ParID);
                    cmd.Parameters.AddWithValue(@"NamePar", txtForNamePar.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно изменена!", "Изменение записи");
                    Parameters Parameters = new Parameters();
                    Parameters.Visible = true;
                    Parameters.ShowInTaskbar = true;
                    this.Close();
                    GC.Collect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
