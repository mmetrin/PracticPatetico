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
    public partial class AddProduct : Form
    {
        // метод, который инициализирует все компоненты, расположенные на форме
        public AddProduct() => InitializeComponent();

        // закрытие данной формы и переход на форму списка товаров
        private void picArrawBack_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            ProductsAdmin ProductsAdmin = new ProductsAdmin();
            ProductsAdmin.Visible = true;
            ProductsAdmin.ShowInTaskbar = true;
        }

        // добавление записи в БД после заполнения необходимых полей 
        private void roundBtnChange_Click(object sender, EventArgs e)
        {
            if (txtForProductName.Text != "" && txtForPrice.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO [Products] VALUES (@product,@description,@price,@weight,@id_parameter)";
                        cmd.Parameters.AddWithValue(@"product", txtForProductName.Text);
                        cmd.Parameters.AddWithValue(@"description", txtForDescription.Text);
                        cmd.Parameters.AddWithValue(@"price", Convert.ToDouble(txtForPrice.Text));
                        cmd.Parameters.AddWithValue(@"weight", Convert.ToDouble(txtForWeight.Text));
                        cmd.Parameters.AddWithValue(@"id_parameter", comboBoxParameters.SelectedValue);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно добавлена!","Добавление записи");
                        AddProduct AddProduct = new AddProduct();
                        AddProduct.Visible = true;
                        AddProduct.ShowInTaskbar = true;
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
                MessageBox.Show("Введите наименование и цену товара!");
                txtForProductName.Focus();
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pateticoPracticDataSet.Parameters". При необходимости она может быть перемещена или удалена.
            this.parametersTableAdapter.Fill(this.pateticoPracticDataSet.Parameters);
        }
    }
}
