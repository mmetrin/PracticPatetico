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
    public partial class ChangeShop : Form
    {
        int ShopID;
        // метод, который инициализирует все компоненты, расположенные на форме
        public ChangeShop(int ID, string Street,  string Time)
        {
            InitializeComponent();
            ShopID = ID;
            txtForStreet.Text = Street;
            txtForTime.Text = Time;
        }

        //закрытие данной формы и переход на форму магазинов
        private void picArrawBack_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Shops Shops = new Shops();
            Shops.Visible = true;
            Shops.ShowInTaskbar = true;
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
                    cmd.CommandText = "UPDATE [Shops] SET address = @Street, time_of_work = @Time WHERE id_shop = @ID";
                    cmd.Parameters.AddWithValue(@"ID", ShopID);
                    cmd.Parameters.AddWithValue(@"Street", txtForStreet.Text);
                    cmd.Parameters.AddWithValue(@"Time", txtForTime.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно изменена!","Изменение записи");
                    Shops Shops = new Shops();
                    Shops.Visible = true;
                    Shops.ShowInTaskbar = true;
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
