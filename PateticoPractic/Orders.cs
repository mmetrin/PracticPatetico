using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PateticoPractic
{
    public partial class Orders : Form
    {
        int ID, IDOrder, IndexRow;
        string Status, Email, Address;
        // метод, который инициализирует все компоненты, расположенные на форме
        public Orders()
        {
            InitializeComponent();
        }

        //загрузка данных записей из таблиц бд при открытии формы
        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pateticoPracticDataSet.Status". При необходимости она может быть перемещена или удалена.
            statusTableAdapter.Fill(pateticoPracticDataSet.Status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pateticoPracticDataSet.Orders". При необходимости она может быть перемещена или удалена.
            ordersTableAdapter.Fill(pateticoPracticDataSet.Orders);
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
            {
                string query = "SELECT bs.id_basket, u.email, o.final_price, s.address, s.time_of_work, o.delivery_date, st.status, o.id_order FROM Orders AS o INNER JOIN Basket AS bs ON bs.id_basket = o.id_basket INNER JOIN Shops as s ON s.id_shop = o.id_shop INNER JOIN Users as u ON u.id_user = bs.id_user  INNER JOIN Status as st ON st.id_status = o.id_status";
            try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    conn.Close();
                    TableOrders.DataSource = dt;
                    TableOrders.Update();
                    TableOrders.Columns[0].Width = 70;
                    TableOrders.Columns[1].Width = 210;
                    TableOrders.Columns[2].Width = 80;
                    TableOrders.Columns[3].Width = 180;
                    TableOrders.Columns[4].Width = 110;
                    TableOrders.Columns[5].Width = 110;
                    TableOrders.Columns[6].Width = 77;
                    TableOrders.Columns[7].Width = 77;

                    TableOrders.Columns[0].HeaderText = "Номер корзины";
                    TableOrders.Columns[1].HeaderText = "Эл. почта клиента";
                    TableOrders.Columns[2].HeaderText = "Сумма к оплате";
                    TableOrders.Columns[3].HeaderText = "Адрес магазина";
                    TableOrders.Columns[4].HeaderText = "Время работы магазина";
                    TableOrders.Columns[5].HeaderText = "Дата доставки";
                    TableOrders.Columns[6].HeaderText = "Статус заказа";
                    TableOrders.Columns[7].Visible = false;
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

        //закрытие данной формы и переход к форме меню администратора
        private void picArrawBack_Click(object sender, EventArgs e)
        {
            Close();
            GC.Collect();
            MenuAdmin MenuAdmin = new MenuAdmin
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

       //поиск по статусу заказа, выбранному в выпадающем списке
        private void roundBtnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
            {
                try
                {
                    string s = comboBoxStatus.GetItemText(comboBoxStatus.SelectedItem);
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT bs.id_basket, u.email, o.final_price, s.address, s.time_of_work, o.delivery_date, st.status FROM Orders AS o INNER JOIN Basket AS bs ON bs.id_basket = o.id_basket INNER JOIN Shops as s ON s.id_shop = o.id_shop INNER JOIN Users as u ON u.id_user = bs.id_user  INNER JOIN Status as st ON st.id_status = o.id_status WHERE st.status like '%" + s + "%'", conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    TableOrders.DataSource = dataTable;
                    TableOrders.Refresh();
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

        //передача данных на форму изменения данных о выбранном заказе и открытие соответсвующей формы
        private void roundBtnChange_Click(object sender, EventArgs e)
        {
            if (TableOrders.SelectedRows.Count == 1)
            {
                Status = TableOrders[6, IndexRow].Value.ToString();
                Email = TableOrders[1, IndexRow].Value.ToString();
                Address = TableOrders[3, IndexRow].Value.ToString();
                Visible = false;
                ShowInTaskbar = false;
                ChangeOrder ChangeOrder = new ChangeOrder(ID, Status, Email, Address);
                ChangeOrder.ShowDialog();
            }
            else
            {
                if (TableOrders.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для изменения!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для изменения!");
                }
            }
        }

        //удаление данных выбранной записи из таблиц бд
        private void roundBtnDelete_Click(object sender, EventArgs e)
        {
            if (TableOrders.SelectedRows.Count == 1)
            {              
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
                            string s = comboBoxStatus.GetItemText(comboBoxStatus.SelectedItem);
                            conn.Open();
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.CommandText = "DELETE FROM [Orders] WHERE id_order = @ID";
                            cmd.Parameters.AddWithValue(@"ID", ID);
                            cmd.ExecuteScalar();
                            TableOrders.Refresh();
                            MessageBox.Show("Запись удалена!");
                            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT bs.id_basket, u.email, o.final_price, s.address, s.time_of_work, o.delivery_date, st.status, o.id_order FROM Orders AS o INNER JOIN Basket AS bs ON bs.id_basket = o.id_basket INNER JOIN Shops as s ON s.id_shop = o.id_shop INNER JOIN Users as u ON u.id_user = bs.id_user  INNER JOIN Status as st ON st.id_status = o.id_status", conn);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            TableOrders.DataSource = dataTable;
                            TableOrders.Refresh();
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
                if (TableOrders.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для удаления!");
                }
            }
        }

        //закрытие данной формы и переход на форму подробностей о содержимом заказа
        private void roundBtnInfo_Click(object sender, EventArgs e)
        {
            if (TableOrders.SelectedRows.Count == 1)
            {
                IDOrder = Convert.ToInt32(TableOrders[7, IndexRow].Value.ToString());
                Visible = false;
                ShowInTaskbar = false;
                OrderInfo OrderInfo = new OrderInfo(IDOrder);
                OrderInfo.ShowDialog();
            }
            else
            {
                if (TableOrders.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для просмотра подробностей о заказе!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для просмотра подробностей о заказе!");
                }
            }
        }
        
        //считывание id заказа выбранной строчки
        private void TableOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TableOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ID = Convert.ToInt32(TableOrders[7, e.RowIndex].Value);
                IndexRow = e.RowIndex;
            }
            catch { }
        }
    }
}
