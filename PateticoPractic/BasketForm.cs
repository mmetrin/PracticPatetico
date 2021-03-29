using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PateticoPractic
{
    public partial class BasketForm : Form
    {
        int IDProduct = 0;
        //метод, который инициализирует все компоненты, расположенные на форме
        public BasketForm() => InitializeComponent();

        //загрузка нужных данных при открытии формы
        private void BasketContentLoad()
        {            
            //подключение к базе sql сервер
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
            {
                string query = "SELECT bp.[id_product], pr.[product_name], bp.[count], bp.price FROM [BasketProduct] AS bp " +
                    "INNER JOIN [Products] AS pr ON bp.[id_product] = pr.[id_product] WHERE [id_basket] = @IDBasket";
                string query2 = "SELECT time_of_work FROM Shops WHERE id_shop = @IdShop";
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);  
                    command.Parameters.AddWithValue(@"IDBasket",Authorization.Basket.ID);

                    //добавление команды для отображения времени работы выбранного в выпадающем списке пункта вывоза
                    SqlCommand command2 = new SqlCommand(query2, conn);
                    command2.Parameters.AddWithValue(@"IDShop", Convert.ToInt32(comboBoxShop.SelectedValue));
                    string TimeWork = command2.ExecuteScalar().ToString();
                    labTimeOfWork.Text = TimeWork;
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    
                    //инициализация переменной для суммирования цен добавленных в корзину товаров
                    int price = 0;
                    for(int i = 0;  i<dt.Rows.Count;i++)
                    {
                        dt.Rows[i][3] = Convert.ToInt32(dt.Rows[i][3]);
                        price += Convert.ToInt32(dt.Rows[i][3]);
                    }
                    labForPrice.Text = price.ToString();
                    reader.Close();
                    tableForProduct.DataSource = dt;
                    tableForProduct.Update();
                    tableForProduct.Columns[0].Visible = false;
                    tableForProduct.Columns[1].HeaderText = "Название";
                    tableForProduct.Columns[2].HeaderText = "Количество";
                    tableForProduct.Columns[3].HeaderText = "Цена, руб";
                    tableForProduct.Refresh();                    
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

        private void BasketForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pateticoPracticDataSet1.Shops". При необходимости она может быть перемещена или удалена.
            this.shopsTableAdapter.Fill(this.pateticoPracticDataSet1.Shops);
            BasketContentLoad();
        }
        
        //считывание id товара выбранной строчки
        private void tableForProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDProduct = Convert.ToInt32(tableForProduct[0, e.RowIndex].Value);
            }
            catch 
            {
                IDProduct = Convert.ToInt32(tableForProduct[0, 0].Value);
            }
        }

        // метод для формирования PDF-фвйла с содержимым заказа с помощью iText 7 
        private void PDFCreate() 
        {
            //подключение к базе sql сервер
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
            {
                string query = "SELECT pr.product_name, b.count, b.price FROM Products AS pr INNER JOIN BasketProduct AS b ON b.id_product = pr.id_product WHERE id_basket = @IdBasket";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue(@"IdBasket", Authorization.Basket.ID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable tableContracts = new DataTable();
                    tableContracts.Load(reader);
                    //путь до создаваемого документа с информациоей о составе оформленного заказа
                    string dest = "C:\\Users\\User\\Desktop\\ConsistOfOrder.pdf";
                    PdfWriter writer = new PdfWriter(dest);
                    PdfDocument pdfDoc = new PdfDocument(writer);
                    Document doc = new Document(pdfDoc);
                    Table table = new Table(tableContracts.Columns.Count);
                    PdfFont russian = PdfFontFactory.CreateFont("c:/Users/User/Desktop/CormorantInfant-Regular.ttf", "CP1251", true);
                    doc.SetFont(russian);
                    table.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                    table.SetFontColor(new DeviceRgb(0, 0, 0));
                    //оформление цвета текста для заголовка таблицы
                    iText.Kernel.Colors.Color color = new DeviceRgb(245, 215, 220);
                    CreateCell(table, "Название", 300, color);
                    CreateCell(table, "Количество", 100, color);
                    CreateCell(table, "Цена, руб.", 100, color);
                    //оформление и заполнение таблицы данными
                    for (int i = 0; i < tableContracts.Rows.Count; i++)
                    {
                        for (int j = 0; j < tableContracts.Columns.Count; j++)
                        {
                            Cell cell = new Cell();
                            if (j == 2) cell.Add(new Paragraph(Convert.ToInt32(tableContracts.Rows[i][j]).ToString()));
                            else cell.Add(new Paragraph(tableContracts.Rows[i][j].ToString()));
                            cell.SetBackgroundColor(new DeviceRgb(255, 255, 255));
                            cell.SetFontSize(12);
                            table.AddCell(cell);
                        }
                    }
                    //создание второй таблицы в документе для отображения общей суммы к оплате заказа
                    Table tableFinalPrice = new Table(2);
                    tableFinalPrice.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                    tableFinalPrice.SetFontColor(new DeviceRgb(0, 0, 0));
                    iText.Kernel.Colors.Color color1 = new DeviceRgb(255, 185, 196);
                    CreateCell(tableFinalPrice, "Финальная цена, руб.", 300, color1);
                    CreateCell(tableFinalPrice, labForPrice.Text, 204, color);
                    doc.Add(new Paragraph("Содержимое Вашего заказа представлено в таблице! Заказ прибудет по адресу "+ comboBoxShop.Text));
                    doc.Add(new Paragraph("\n"));
                    doc.Add(table);
                    doc.Add(tableFinalPrice);
                    doc.Close();

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

        // метод для отправки сообщения и PDF-файла с содержимым заказа на почту клиенту
        private static async Task SendEmailAsync(string Email) 
        {
            //// отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("6mikhaylovakatya9@gmail.com", "Кондитерская 'Patetico&Dolce'");
            // кому отправляем
            MailAddress to = new MailAddress(Email);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Ваш заказ оформлен";
            // текст письма
            m.Body = $"Ваш заказ оформлен, как только он будет готов, вам придет сообщение!";
            // отправляем пдф файл с составом заказа
            m.Attachments.Add(new Attachment("C:\\Users\\User\\Desktop\\ConsistOfOrder.pdf"));
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            // логин и пароль
            smtp.Credentials = new NetworkCredential("6mikhaylovakatya9@gmail.com", "Maksimka528369");
            await smtp.SendMailAsync(m);
        }

        // метод для определения стиля столбцов/строк в таблице в PDF-файле 
        private void CreateCell(Table table, string str, float widthCell, iText.Kernel.Colors.Color bgColor)
        {
            Cell cell1 = new Cell();
            cell1.Add(new Paragraph(str));
            cell1.SetWidth(widthCell);
            cell1.SetFontSize(14);
            cell1.SetBackgroundColor(bgColor);
            table.AddCell(cell1);
        }

        //вызов метода возвращения в меню клиента
        private void picArrowBack_Click(object sender, EventArgs e)
        {
            backToMain();
        }

        //метод для закрытия данной формы и возвращения в меню клиента
        private void backToMain()
        {
            this.Close();
            GC.Collect();
            MenuUser menuUser = new MenuUser();
            menuUser.Show();
        }

        //вызов метода возвращения в меню клиента
        private void labelBack_Click(object sender, EventArgs e)
        {
            backToMain();
        }

        //удаление выбранной записи таблицы
        private void roundBtnDelete_Click(object sender, EventArgs e)
        {
            if (tableForProduct.SelectedRows.Count == 1)
            {
                if (IDProduct == 0) IDProduct = Convert.ToInt32(tableForProduct[0, 0].Value);
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
                            cmd.CommandText = "DELETE FROM [BasketProduct] WHERE [id_product] = @ID";
                            cmd.Parameters.AddWithValue(@"ID", IDProduct);
                            cmd.ExecuteScalar();
                            BasketContentLoad();
                            MessageBox.Show("Запись удалена!");
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
                if (tableForProduct.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Вы не выбрали строку для удаления!");
                }
                else
                {
                    MessageBox.Show("Выберите ТОЛЬКО ОДНУ строку для удаления!");
                }
            }
        }

        //метод, совершаемый при попытке оформить заказ
        private void roundBtnPlace_Click(object sender, EventArgs e)
        {
            //проверка на нулевое значение суммы к оплате заказа
            if (labForPrice.Text == "0")
            {
                MessageBox.Show("Ваша корзина пуста!\nДобавьте товары в корзину и попробуйте еще раз!","К сожалению, оформить заказ невозможно");
            }
            else
            {
                //подключение к базе sql сервер
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        SqlCommand cmd1 = conn.CreateCommand();
                        cmd1.CommandText = "SELECT [id_user] FROM [Basket] WHERE [id_basket] = @IdBasket";
                        cmd1.Parameters.AddWithValue(@"IdBasket", Authorization.Basket.ID);
                        int UserID = Convert.ToInt32(cmd1.ExecuteScalar());
                        DateTime dateTime = DateTime.Today;
                        cmd.CommandText = "INSERT INTO [Orders] values(@DelivDate,@price,@IDUser,@IdBasket,@IDShop,@IDStatus)";
                        cmd.Parameters.AddWithValue(@"DelivDate", dateTime);
                        cmd.Parameters.AddWithValue(@"price", Convert.ToInt32(labForPrice.Text));
                        cmd.Parameters.AddWithValue(@"IDUser", UserID);
                        cmd.Parameters.AddWithValue(@"IdBasket", Authorization.Basket.ID);
                        cmd.Parameters.AddWithValue(@"IDShop", comboBoxShop.SelectedValue);
                        cmd.Parameters.AddWithValue(@"IDStatus", 3);
                        cmd.ExecuteScalar();
                        //вызов метода на формирование pdf документа
                        PDFCreate();
                        //вызов метода отправки сообщения на почту
                        SendEmailAsync(Authorization.User.Email).GetAwaiter();
                        Console.Read();
                        MessageBox.Show("Заказ оформлен!");
                        SqlCommand cmd2 = conn.CreateCommand();
                        cmd2.CommandText = "DELETE FROM [BasketProduct] WHERE [id_basket] = @IdBasket";
                        cmd2.Parameters.AddWithValue(@"IdBasket", Authorization.Basket.ID);
                        cmd2.ExecuteNonQuery();
                        BasketContentLoad();
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
        
        //метод для изменения поля времени работы магазина в зависимости от выбранного пункта вывоза
        private void comboBoxShop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
            {
                string query2 = "SELECT time_of_work FROM Shops WHERE id_shop = @IdShop";
                try
                {
                    conn.Open();
                    SqlCommand command2 = new SqlCommand(query2, conn);
                    command2.Parameters.AddWithValue(@"IDShop", Convert.ToInt32(comboBoxShop.SelectedValue));
                    string TimeWork = command2.ExecuteScalar().ToString();
                    labTimeOfWork.Text = TimeWork;
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
