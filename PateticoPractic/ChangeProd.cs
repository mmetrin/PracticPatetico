using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PateticoPractic
{
    public partial class ChangeProd : Form
    {
        int ProdID;
        // метод, который инициализирует все компоненты, расположенные на форме
        public ChangeProd(int ID, string name, string description, string price, string weight, string parameter)
        {
            InitializeComponent();
            ProdID = ID;
            txtForProductName.Text = name;
            txtForDescription.Text = description;
            txtForPrice.Text = price;
            txtForWeight.Text = weight;
            comboBoxParameters.SelectedValue = parameter;
        }
             
        //закрытие данной формы и переход к форме списка товаров
        private void picArrawBack_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            ProductsAdmin ProductsAdmin = new ProductsAdmin();
            ProductsAdmin.Visible = true;
            ProductsAdmin.ShowInTaskbar = true;
        }

        private void ChangeProd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pateticoPracticDataSet.Parameters". При необходимости она может быть перемещена или удалена.
            this.parametersTableAdapter.Fill(this.pateticoPracticDataSet.Parameters);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pateticoPracticDataSet.Products". При необходимости она может быть перемещена или удалена.
            //this.productsTableAdapter.Fill(this.pateticoPracticDataSet.Products);

        }

        //изменение данных записи в таблице бд по заполненным полям и закрытие формы
        private void roundBtnChange_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))

            {
                double price1 = 0, weight1 = 0;
                try
                {
                    price1 = Convert.ToDouble(txtForPrice.Text);
                    weight1 = Convert.ToDouble(txtForWeight.Text);

                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        //SqlCommand cmd_1 = conn.CreateCommand();
                        cmd.CommandText = "UPDATE [Products] SET product_name = @Name, description = @Content, price = @Price, weight = @Weight, id_parameter = @IDPar WHERE id_product = @ID";
                        cmd.Parameters.AddWithValue(@"ID", ProdID);
                        cmd.Parameters.AddWithValue(@"Name", txtForProductName.Text);
                        cmd.Parameters.AddWithValue(@"Content", txtForDescription.Text);
                        cmd.Parameters.AddWithValue(@"Price", price1);
                        cmd.Parameters.AddWithValue(@"Weight", weight1);
                        cmd.Parameters.AddWithValue(@"IDPar", comboBoxParameters.SelectedValue);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно изменена!","Изменение записи");
                        ProductsAdmin ProductsAdmin = new ProductsAdmin();
                        ProductsAdmin.Visible = true;
                        ProductsAdmin.ShowInTaskbar = true;
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
                catch
                {
                    MessageBox.Show("Введите корректную цену!");
                    txtForPrice.Text = "";
                }
            }
        }
    }
}
