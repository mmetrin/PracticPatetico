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
    public partial class AddParameter : Form
    {
        // метод, который инициализирует все компоненты, расположенные на форме
        public AddParameter() => InitializeComponent();

        // добавление записи в БД после заполнения необходимых полей
        private void roundBtnAdd_Click(object sender, EventArgs e)
        {
            if (txtForNamePar.Text != "")
            {
                //подключение к базе sql сервер
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO [Parameters] VALUES (@parameter)";
                        cmd.Parameters.AddWithValue(@"parameter", txtForNamePar.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно добавлена!", "Добавление записи");
                        txtForNamePar.Clear();
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
            else
            {
                MessageBox.Show("Введите наименование!");
                txtForNamePar.Focus();
            }
        }
        
        // закрытие данной формы и переход на форму категорий товаров
        private void picArrawBack_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Parameters Parameters = new Parameters();
            Parameters.Visible = true;
            Parameters.ShowInTaskbar = true;
        }
    }
}
