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
    public partial class Parameters : Form
    {
        int ID, IndexRow;
        string NamePar;
        // метод, который инициализирует все компоненты, расположенные на форме
        public Parameters() => InitializeComponent();

        //удаление данных выбранной записи из таблицы бд
        private void roundBtnDelete_Click(object sender, EventArgs e)
        {
            if (TableParameters.SelectedRows.Count == 1)
            {
                ID = int.Parse(TableParameters.Rows[TableParameters.CurrentRow.Index].Cells[TableParameters.CurrentCell.ColumnIndex].Value.ToString());

                string message = $"Вы действительно хотите удалить данную запись?\nОтменить это действие будет невозможно";
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
                            cmd.CommandText = "DELETE FROM [Parameters] WHERE id_parameter = @ID";
                            cmd.Parameters.AddWithValue(@"ID", ID);
                            cmd.ExecuteScalar();
                            TableParameters.Refresh();
                            MessageBox.Show("Запись удалена!");
                            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT p.id_parameter, p.parameter FROM Parameters AS p", conn);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            TableParameters.DataSource = dataTable;
                            TableParameters.Update();
                            TableParameters.Columns[0].Width = 200;
                            TableParameters.Columns[1].Width = 200;
                            TableParameters.Columns[0].HeaderText = "Номер категории";
                            TableParameters.Columns[1].HeaderText = "Название категории";

                            TableParameters.Refresh();
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
                if (TableParameters.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для удаления!");
                }
            }
        }

        //закрытие данной формы и переход на форму добавления категории товаров
        private void roundBtnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            AddParameter AddParameter = new AddParameter();
            AddParameter.Visible = true;
            AddParameter.ShowInTaskbar = true;
        }

        //закрытие данной формы и переход на форму меню администратора
        private void picArrawBack_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            MenuAdmin MenuAdmin = new MenuAdmin();
            MenuAdmin.Visible = true;
            MenuAdmin.ShowInTaskbar = true;
        }

        //выход из приложения 
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //закрытие данной формы и переход на форму изменения категории товаров
        private void roundBtnChange_Click(object sender, EventArgs e)
        {
            if (TableParameters.SelectedRows.Count == 1)
            {
                NamePar = TableParameters[1, IndexRow].Value.ToString();
                this.Visible = false;
                this.ShowInTaskbar = false;
                ChangeParameter ChangeParameter = new ChangeParameter(ID, NamePar);
                ChangeParameter.ShowDialog();
            }
            else
            {
                if (TableParameters.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для изменения!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для изменения!");
                }
            }
        }

        //считывание id категории товара выбранной строчки
        private void TableParameters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TableParameters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ID = Convert.ToInt32(TableParameters[0, e.RowIndex].Value);
                IndexRow = e.RowIndex;
            }
            catch { }
        }

        //загрузка данных записей из таблиц бд при открытии формы
        private void Parameters_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
            {
                string query = "SELECT p.id_parameter, p.parameter FROM Parameters AS p";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    conn.Close();
                    TableParameters.DataSource = dt;
                    TableParameters.Update();
                    TableParameters.Columns[0].Width = 100;
                    TableParameters.Columns[1].Width = 170;
                    TableParameters.Columns[0].HeaderText = "Номер категории";
                    TableParameters.Columns[1].HeaderText = "Название категории";
                    

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
