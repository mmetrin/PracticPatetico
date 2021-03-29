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
    public partial class InfoProduct : Form
    {
        int IdProduct;
        // метод, который инициализирует все компоненты, расположенные на форме
        public InfoProduct(int IDProd)
        {
            InitializeComponent();
            IdProduct = IDProd;
            LoadInfoProduct();
        }

        //метод при загрузке и открытии формы (загрузка данных всей полей информации о выбранном товаре)
        private void LoadInfoProduct()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
            {
                string query = "SELECT p.[product_name],p.[description],p.[price], p.[weight] FROM [Products] AS p WHERE p.[id_product] = @IDPRod";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.Parameters.AddWithValue(@"IDPRod", IdProduct);
                //ExecuteReader: выполняет sql-выражение и возвращает строки из таблицы
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    txtForProductName.Text = reader.GetValue(0).ToString();
                    txtForDescription.Text = reader.GetValue(1).ToString();
                    txtForPrice.Text= Convert.ToInt32(reader.GetValue(2)).ToString();
                    txtForWeight.Text = reader.GetValue(3).ToString();
                    numCount.Focus();
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

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //вызов метода на закрытие данной формы и переход на последнюю закрытую форму
        private void picArrawBack_Click(object sender, EventArgs e)
        {
            backToProducts();
        }

        //удаление товара из корзины
        private void roundBtnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
            {
                int count = Convert.ToInt32(numCount.Value);
                if (count<1) count = 1;
                int price = Convert.ToInt32(txtForPrice.Text) * Convert.ToInt32(numCount.Value);
                try
                {
                    conn.Open();
                    string query = "INSERT INTO [BasketProduct] values (@count,@price, @IdProd,@IdBasket)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue(@"count", count);
                    cmd.Parameters.AddWithValue(@"price", price);
                    cmd.Parameters.AddWithValue(@"IdProd", IdProduct);
                    cmd.Parameters.AddWithValue(@"IdBasket", Authorization.Basket.ID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Продукт добавлен в корзину!");
                    //вызов метода на закрытие данной формы и переход на последнюю закрытую форму
                    backToProducts();
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

        //вызов метода на закрытие данной формы и переход на последнюю закрытую форму
        private void picArrowBack_Click(object sender, EventArgs e)
        {
            backToProducts();

        }

        //метод на закрытие данной формы и переход на последнюю закрытую форму
        private void backToProducts()
        {
            this.Close();
            GC.Collect();
            switch (Categoryes.product.type)
            {
                case 1:
                    ProductCake productCake = new ProductCake();
        productCake.Visible = true;
                    productCake.ShowInTaskbar = true;
                    break;
                case 2:
                    ProductChocolate productChocolate = new ProductChocolate();
        productChocolate.Visible = true;
                    productChocolate.ShowInTaskbar = true;
                    break;
                case 3:
                    ProductPanCakes productPanCakes = new ProductPanCakes();
        productPanCakes.Visible = true;
                    productPanCakes.ShowInTaskbar = true;
                    break;
            }
    }

        //вызов метода на закрытие данной формы и переход на последнюю закрытую форму
        private void labelBack_Click(object sender, EventArgs e)
        {
            backToProducts();
        }
    }
}
