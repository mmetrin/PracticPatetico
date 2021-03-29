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
    public partial class Shops : Form
    {
        // метод, который инициализирует все компоненты, расположенные на форме
        public Shops() => InitializeComponent();
        int ID, IndexRow;
        string Street,Time;

        //закрытие данной формы и переход к форме меню администратора
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
            if (TableShops.SelectedRows.Count == 1)
            {
                Street = TableShops[1, IndexRow].Value.ToString();
                Time = TableShops[2, IndexRow].Value.ToString();
                this.Visible = false;
                this.ShowInTaskbar = false;
                ChangeShop ChangeShop = new ChangeShop(ID, Street, Time);
                ChangeShop.ShowDialog();
            }
            else
            {
                if (TableShops.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для изменения!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для изменения!");
                }
            }
        }

        //закрытие приложения
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //загрузка данных записей из таблиц бд при открытии формы
        private void Shops_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))

            {
                string query = "SELECT s.id_shop, s.address, s.time_of_work FROM Shops AS s";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    conn.Close();
                    TableShops.DataSource = dt;
                    TableShops.Update();
                    TableShops.Columns[1].Width = 400;
                    TableShops.Columns[2].Width = 100;
                    //TableShops.Columns[0].HeaderText = "Номер магазина";
                    TableShops.Columns[1].HeaderText = "Адрес магазина";
                    TableShops.Columns[2].HeaderText = "Время работы магазина";
                    TableShops.Columns[0].Visible = false;

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

        //закрытие данной формы и переход на форму добавления товара
        private void roundBtnAdd_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            AddShop AddShop = new AddShop();
            AddShop.ShowDialog();
        }

        //удаление данных выбранной записи из таблицы бд
        private void roundBtnDelete_Click(object sender, EventArgs e)
        {
            if (TableShops.SelectedRows.Count == 1)
            {
                //ID = int.Parse(TableProducts.Rows[TableProducts.CurrentRow.Index].Cells[TableProducts.CurrentCell.ColumnIndex].Value.ToString());
                string message = $"Вы действительно хотите удалить данную запись?\nОтменить это действие будет невозможно!";
                string caption = "Удаление записи";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))

                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "DELETE FROM [Shops] WHERE id_shop = @ID";
                            cmd.Parameters.AddWithValue(@"ID", ID);
                            cmd.ExecuteScalar();
                            TableShops.Refresh();
                            MessageBox.Show("Запись удалена!");
                            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT s.id_shop, s.address, s.time_of_work FROM Shops AS s", conn);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            TableShops.DataSource = dataTable;
                            TableShops.Update();
                            //TableShops.Columns[0].Width = 70;
                            TableShops.Columns[1].Width = 400;
                            TableShops.Columns[2].Width = 300;                           
                            //TableShops.Columns[0].HeaderText = "Номер магазина";
                            TableShops.Columns[1].HeaderText = "Адрес магазина";
                            TableShops.Columns[2].HeaderText = "Время работы магазина";
                            TableShops.Refresh();
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
                if (TableShops.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для удаления!");
                }
            }
        }

        //считывание id магазина выбранной строчки
        private void TableShops_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TableShops.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ID = Convert.ToInt32(TableShops[0, e.RowIndex].Value);
                IndexRow = e.RowIndex;
            }
            catch { }
        }
    }
}
