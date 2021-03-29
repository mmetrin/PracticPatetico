using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PateticoPractic
{
    public partial class ChangeOrder : Form
    {
        int OrderID;
        string Email, Adress;
        //метод, который инициализирует все компоненты, расположенные на форме
        public ChangeOrder(int ID, string status, string mail, string addres)
        {
            InitializeComponent();
            OrderID = ID;
            comboBoxStatus.SelectedValue = status;
            Email = mail;
            Adress = addres;
        }
        
        private void ChangeOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pateticoPracticDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.pateticoPracticDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pateticoPracticDataSet.Status". При необходимости она может быть перемещена или удалена.
            statusTableAdapter.Fill(pateticoPracticDataSet.Status);
        }

        //закрытие данной формы и переход на форму заказов
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

        //отправка сообщения об измененном статусе заказа на почту клиенту
        private static async Task SendEmailAsync(string Email, string Status, string Adress)
        { //// отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("6mikhaylovakatya9@gmail.com", "Кондитерская 'Patetico&Dolce'");
            // кому отправляем
            MailAddress to = new MailAddress(Email);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Статус вашего заказа изменен";
            // текст письма

            if (Status == "Выполнен")
            {
                m.Body = $"Здравствуйте, Ваш заказ выполнен и ожидает получения по адресу {Adress}";
            }
            else
            {
                m.Body = $"Здравствуйте, статус вашего заказа {Status}";
            }
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            // логин и пароль
            smtp.Credentials = new NetworkCredential("6mikhaylovakatya9@gmail.com", "Maksimka528369");
            await smtp.SendMailAsync(m);

        }
        
        //изменение записи в таблице бд при заполнении полей
        private void roundBtnChange_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE [Orders] SET id_status = @IDSt WHERE id_order = @ID";
                    cmd.Parameters.AddWithValue(@"ID", OrderID);
                    cmd.Parameters.AddWithValue(@"IDSt", comboBoxStatus.SelectedValue);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно изменена!","Изменение записи");
                    Orders Orders = new Orders
                    {
                        Visible = true,
                        ShowInTaskbar = true
                    };
                    Close();
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
            SendEmailAsync(Email, comboBoxStatus.Text, Adress).GetAwaiter();
            Console.Read();
        }
    }
}

