using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PateticoPractic
{
    public partial class Registration : Form
    {
        // метод, который инициализирует все компоненты, расположенные на форме
        public Registration() => InitializeComponent();

        //закрытие данной формы и переход на форму авторизации
        private void picArrawBack_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Authorization Authorization = new Authorization();
            Authorization.Visible = true;
            Authorization.ShowInTaskbar = true;
        }

        //выход из приложения
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //регистрация с занесением данных в базу
        private void roundBtnRegistration_Click(object sender, EventArgs e)
        {
            //проверка на пустые значения
            if (txtForEmail.Text != "" && txtForName.Text != "" && txtForSurname.Text != "" && txtForPhone.Text != "")
            {
                //удаление конечных и начальных пробелов
                txtForEmail.Text.Trim();
                txtForSurname.Text.Trim();
                txtForName.Text.Trim();
                txtForPassword.Text.Trim();
                txtForPatronymic.Text.Trim();
                txtForRepeatPassword.Text.Trim();
                txtForPhone.Text.Trim();

                //инициализация переменной email клиента (адрес+выбранный домен)
                string Email = txtForEmail.Text + comboBoxEmail.Text;

                //проверка на эквивалентность пароля и его повтора
                if (txtForRepeatPassword.Text != txtForPassword.Text)
                {
                    MessageBox.Show("К сожалению, введенные пароли на совпадают, повторите ввод еще раз");
                    txtForRepeatPassword.Focus();
                }
                else
                {
                    if (!IsValidEmail(Email))
                    {
                        MessageBox.Show("К сожалению, адрес электронной почты, введенный Вами, не соотвутствует формату.\nПовторите ввод еще раз.");
                    }
                    else
                    {
                        if (!ValidatePassword(txtForPassword.Text))
                        {
                            MessageBox.Show("К сожалению, пароль, введенный Вами, недостаточно надежен.\nПовторите ввод еще раз, используйте от 6 до 15 символов, хотя бы 1 прописную, 1 заглавную буквы и 1 цифру!");
                        }
                        else
                        {
                            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
                            {
                                try
                                {
                                    conn.Open();
                                    SqlCommand cmd = conn.CreateCommand();
                                    SqlCommand userEmail = conn.CreateCommand();
                                    userEmail.CommandText = "SELECT Email FROM [Users] WHERE email = @Email";
                                    userEmail.Parameters.AddWithValue(@"Email", txtForEmail.Text);

                                    if (userEmail.ExecuteScalar() != null)
                                    {
                                        MessageBox.Show("К сожалению, пользователь с данной почтой уже зарегистрирован.");
                                        txtForEmail.Focus();
                                    }
                                    else
                                    {

                                        cmd.CommandText = "INSERT INTO [Users] VALUES (@email,@password, @name,@surname, @patronymic, @date_of_birth,@phone,@rolead)";
                                        cmd.Parameters.AddWithValue("@name", txtForName.Text);
                                        cmd.Parameters.AddWithValue("@surname", txtForSurname.Text);
                                        cmd.Parameters.AddWithValue("@patronymic", txtForPatronymic.Text);
                                        cmd.Parameters.AddWithValue("@email", Email);
                                        cmd.Parameters.AddWithValue("@date_of_birth", dateForDateBirth.Value);
                                        cmd.Parameters.AddWithValue("@password", txtForPassword.Text);
                                        cmd.Parameters.AddWithValue("@rolead", "U");
                                        cmd.Parameters.AddWithValue("@phone", txtForPhone.Text);
                                        cmd.ExecuteNonQuery();
                                        string query = "SELECT [id_user] FROM [Users] WHERE [email] = @email";
                                        SqlCommand cmd2 = new SqlCommand(query,conn);
                                        cmd2.Parameters.AddWithValue(@"email",Email);
                                        int UserId = Convert.ToInt32(cmd2.ExecuteScalar());
                                        string query2 = "INSERT INTO [Basket] values (@IdUser)";
                                        SqlCommand cmd3 = new SqlCommand(query2, conn);
                                        cmd3.Parameters.AddWithValue(@"IdUser",UserId);
                                        cmd3.ExecuteScalar();
                                        this.Close();
                                        GC.Collect();
                                        Authorization Authorization = new Authorization();
                                        Authorization.Show();
                                    }
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
            }
            else
            {
                MessageBox.Show("К сожалению, Ваши данные не обнаружены :( Введите их еще раз!");
            }
        }

        //проверка на верную запись эл. почты
        public static bool IsValidEmail(string email)
        {
            //проверка на пустое значение
            if (string.IsNullOrWhiteSpace(email))
                return false;
            try
            {
                //проверка на соответствие домена сущесствующим
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));
                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }
            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        //проверка на верную запись пароля
        static bool ValidatePassword(string password)
        {
            //инициализация минимальной и максимальной длин пароля посимвольно
            const int MIN_LENGTH = 6;
            const int MAX_LENGTH = 15;
            
            //проверка на пустое значение
            if (password == null) throw new ArgumentNullException();

            //проверка соответствия критерию длины пароля
            bool meetsLengthRequirements = password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH;

            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            //проверка пароля на соответствие критериям наличия букв верхнего, нижнего регистра и десятичной цифры 
            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                }
            }

            bool isValid = meetsLengthRequirements
                        && hasUpperCaseLetter
                        && hasLowerCaseLetter
                        && hasDecimalDigit
                        ;
            return isValid;
        }

        //проверка записи даты рождения
        private void dateForDateBirth_Validated(object sender, EventArgs e)
        {
            DateTime date = new DateTime(2010, 01, 01);
            if (dateForDateBirth.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Такой год еще не наступил, выберите корректную дату");
                dateForDateBirth.Value = date;
            }
            else if (dateForDateBirth.Value.Year + 12 > DateTime.Now.Year)
            {
                MessageBox.Show("Извините, но Ваш возраст не соответствует правилам пользования нашей программы");
                dateForDateBirth.Value = date;
            }
        }
        
        //ограничение по длине номера телефона
        private void txtForPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtForPhone.TextLength > 11)
            {
                txtForPhone.ReadOnly = true;
            }
        }

        //допуск значений цифр и нажатия клавиши backspace для поля номера телефона
        private void txtForPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }        
    }
}
