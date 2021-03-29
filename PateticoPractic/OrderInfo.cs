using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PateticoPractic
{
    public partial class OrderInfo : Form
    {
        int IDOrder;
        // метод, который инициализирует все компоненты, расположенные на форме
        public OrderInfo(int ID)
        {
            InitializeComponent();
            IDOrder = ID;
        }

        //закрытие данной формы и переход к форме заказов
        private void picArrawBack_Click(object sender, EventArgs e)
        {
            Close();
            GC.Collect();
            Orders Orders = new Orders
            {
                Visible = true,
                ShowInTaskbar = true
            };
        }

        //выход из приложения
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //загрузка данных записей из таблиц бд при открытии формы
        private void OrderInfo_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
            {
                string query = "SELECT o.id_order, bs.id_basket, p.parameter, pr.product_name, pr.description, pr.price, pr.weight, bspr.count FROM Orders AS o " +
                    "INNER JOIN Basket AS bs ON bs.id_basket = o.id_basket INNER JOIN BasketProduct as bspr ON bspr.id_basket = bs.id_basket " +
                    "INNER JOIN Products as pr ON pr.id_product = bspr.id_product INNER JOIN Parameters as p ON p.id_parameter = pr.id_parameter WHERE o.id_order = @ID";

                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue(@"ID", IDOrder);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    conn.Close();
                    TableOrders.DataSource = dt;
                    TableOrders.Update();
                    TableOrders.Columns[1].Width = 80;
                    TableOrders.Columns[2].Width = 120;
                    TableOrders.Columns[3].Width = 180;
                    TableOrders.Columns[4].Width = 220;
                    TableOrders.Columns[5].Width = 80;
                    TableOrders.Columns[6].Width = 77;
                    TableOrders.Columns[7].Width = 77;

                    TableOrders.Columns[0].Visible = false;
                    TableOrders.Columns[1].HeaderText = "Номер корзины";
                    TableOrders.Columns[2].HeaderText = "Категория товара";
                    TableOrders.Columns[3].HeaderText = "Название товара";
                    TableOrders.Columns[4].HeaderText = "Описание товара";
                    TableOrders.Columns[5].HeaderText = "Цена";
                    TableOrders.Columns[6].HeaderText = "Вес";
                    TableOrders.Columns[7].HeaderText = "Кол-во";


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
