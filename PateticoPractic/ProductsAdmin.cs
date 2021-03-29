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
    public partial class ProductsAdmin : Form
    {
        // метод, который инициализирует все компоненты, расположенные на форме
        public ProductsAdmin() => InitializeComponent();

        int ID, IndexRow;
        string NameProduct, Description, Parameter;

        // закрытие данной формы и переход к форме меню администратора
        private void picArrawBack_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            MenuAdmin MenuAdmin = new MenuAdmin();
            MenuAdmin.Visible = true;
            MenuAdmin.ShowInTaskbar = true;
        }

        //закрытие данной формы и переход на форму изменения товарв
        private void roundBtnChange_Click(object sender, EventArgs e)
        {
            if (TableProducts.SelectedRows.Count == 1)
            {
                NameProduct = TableProducts[1, IndexRow].Value.ToString();
                Description = TableProducts[2, IndexRow].Value.ToString();
                string Price1 = Convert.ToString(TableProducts[3, IndexRow].Value.ToString());              
                string Weight1 = TableProducts[4, IndexRow].Value.ToString();
                Parameter = TableProducts[5, IndexRow].Value.ToString();
                this.Visible = false;
                this.ShowInTaskbar = false;
                ChangeProd ChangeProd = new ChangeProd(ID, NameProduct, Description, Price1, Weight1, Parameter);
                ChangeProd.ShowDialog();
            }
            else
            {
                if (TableProducts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для изменения!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для изменения!");
                }
            }
        }

        //удаление данных выбранной записи из таблицы бд
        private void roundBtnDelete_Click(object sender, EventArgs e)
        {
            if (TableProducts.SelectedRows.Count == 1)
            {
                string message = $"Вы действительно хотите удалить данную запись?\nОтменить это действие будет невозможно!";
                string caption = "Удаление записи";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    // подключение к базе sql сервер
                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))

                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "DELETE FROM [Products] WHERE id_product = @ID";
                            cmd.Parameters.AddWithValue(@"ID", ID);
                            cmd.ExecuteScalar();
                            TableProducts.Refresh();
                            MessageBox.Show("Запись удалена!");
                            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT p.id_product, p.product_name, p.description, p.price, p.weight, p.id_parameter, pr.parameter FROM Products AS p INNER JOIN Parameters as pr ON pr.id_parameter = p.id_parameter", conn);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            TableProducts.DataSource = dataTable;
                            TableProducts.Update();
                            TableProducts.Columns[0].Width = 50;
                            TableProducts.Columns[1].Width = 100;
                            TableProducts.Columns[2].Width = 400;
                            TableProducts.Columns[3].Width = 70;
                            TableProducts.Columns[4].Width = 50;

                            TableProducts.Columns[6].Width = 70;
                            TableProducts.Columns[0].HeaderText = "Номер товара";
                            TableProducts.Columns[1].HeaderText = "Название товара";
                            TableProducts.Columns[2].HeaderText = "Описание товара";
                            TableProducts.Columns[3].HeaderText = "Цена товара";
                            TableProducts.Columns[4].HeaderText = "Вес (г)";
                            TableProducts.Columns[6].HeaderText = "Категория товара";
                            TableProducts.Columns[5].Visible = false;
                            TableProducts.Refresh();
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
                    MessageBox.Show("Запись не удалена!");
                }
            }
            else
            {
                if (TableProducts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для удаления!");
                }
            }
        }

        //считывание id товара выбранной строчки
        private void TableProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TableProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ID = Convert.ToInt32(TableProducts[0, e.RowIndex].Value);
                IndexRow = e.RowIndex;
            }
            catch { }
        }

        //закрытие данной формы и переход на форму добавления товара
        private void roundBtnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            AddProduct AddProduct = new AddProduct();
            AddProduct.Visible = true;
            AddProduct.ShowInTaskbar = true;
        }

        //очистка текста в поле для поиска при нажатии на него пользователем 
        private void txtForName_Click(object sender, EventArgs e)
        {
            if (txtForName.Text == "Введите название изделия для поиска")
            {
                txtForName.Text = "";
            }
        }

        //осуществление поиска в списке по наименованию товара 
        private void roundBtnSearch_Click(object sender, EventArgs e)
        {
            // подключение к базе sql сервер
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT p.id_product, p.product_name, p.description, p.price, p.weight, pr.parameter FROM Products AS p INNER JOIN Parameters as pr ON pr.id_parameter = p.id_parameter WHERE p.product_name like '%" + txtForName.Text +"%'", conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    TableProducts.DataSource = dataTable;
                    TableProducts.Refresh();
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

        //закрытие приложения
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //загрузка данных записей из таблиц бд при открытии формы
        private void ProductsAdmin_Load(object sender, EventArgs e)
        {
            // подключение к базе sql сервер
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
            {
                string query = "SELECT p.id_product, p.product_name, p.description, p.price, p.weight, p.id_parameter, pr.parameter FROM Products AS p INNER JOIN Parameters as pr ON pr.id_parameter = p.id_parameter ";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    conn.Close();
                    TableProducts.DataSource = dt;
                    TableProducts.Update();
                    TableProducts.Columns[0].Width = 50;
                    TableProducts.Columns[1].Width = 140;
                    TableProducts.Columns[2].Width = 580;
                    TableProducts.Columns[3].Width = 60;
                    TableProducts.Columns[4].Width = 60;

                    TableProducts.Columns[6].Width = 90;
                    TableProducts.Columns[0].HeaderText = "Номер товара";
                    TableProducts.Columns[1].HeaderText = "Название товара";
                    TableProducts.Columns[2].HeaderText = "Описание товара";
                    TableProducts.Columns[3].HeaderText = "Цена товара";
                    TableProducts.Columns[4].HeaderText = "Вес (г)";
                    TableProducts.Columns[6].HeaderText = "Категория товара";
                    TableProducts.Columns[5].Visible = false;

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
