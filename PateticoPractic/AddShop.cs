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
    public partial class AddShop : Form
    {
        //метод, который инициализирует все компоненты, расположенные на форме
        public AddShop() => InitializeComponent();

        // закрытие данной формы и переход на форму списка магазинов
        private void picArrawBack_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Shops Shops = new Shops();
            Shops.Visible = true;
            Shops.ShowInTaskbar = true;
        }

        // добавление записи в БД после заполнения необходимых полей 
        private void roundBtnAdd_Click(object sender, EventArgs e)
        {
            if (txtForStreet.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))

                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO [Shops] VALUES (@street,@time)";
                        cmd.Parameters.AddWithValue(@"street", txtForStreet.Text);
                        cmd.Parameters.AddWithValue(@"time", txtForTime.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно добавлена!", "Добавление записи");
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
            else
            {
                MessageBox.Show("Введите адрес магазина!");
                txtForStreet.Focus();
            }
        }
    }
}
