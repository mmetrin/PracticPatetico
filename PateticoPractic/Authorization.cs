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
    public partial class Authorization : Form
    {
        //инициализация глобальных переменных, используемых в других формах (привязка номера корзины к клиенту)
        static public Global Basket, User;
        public struct Global
        {
            public int ID;
            public string Email;
        }

        //метод, который инициализирует все компоненты, расположенные на форме
        public Authorization() => InitializeComponent();

        //выход из приложения
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //скрытие пароля с помощью звездочек
        private void txtForPassword_TextChanged(object sender, EventArgs e)
        {
            txtForPassword.PasswordChar = '*';
        }

        //открытие формы регистрации
        private void labelReg_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
            this.Hide();
        }
       
        //осуществление входа с проверкой данных на подлинность
        private void roundBtnAuthorization_Click(object sender, EventArgs e)
        {
            if (txtForLogin.Text != "")
            {
                if (txtForPassword.Text != "")
                {
                    //подключение к базе sql сервер
                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9IUFQMM\SQLEXPRESS;Initial Catalog=PateticoPractic;Integrated Security=True"))
                    {
                        string email = txtForLogin.Text;
                        string password = txtForPassword.Text;
                        string sql_1 = "SELECT password FROM [Users] WHERE email = @Email";
                        string sql_2 = "SELECT rolead FROM [Users] WHERE email = @Email";
                        string sql_3 = "SELECT id_user FROM [Users] WHERE email = @Email";
                        string password_check = "";
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(sql_1, conn);
                            cmd.Parameters.AddWithValue("@Email", email);

                            //ExecuteScalar выполняет sql-выражение и возвращает скалярное значение - почту пользователя
                            //производится проверка на пустое значение
                            if (cmd.ExecuteScalar() != null) 
                            {
                                password_check = cmd.ExecuteScalar().ToString();
                                if (password == password_check)
                                {
                                    SqlCommand cmd_2 = new SqlCommand(sql_2, conn);
                                    cmd_2.Parameters.AddWithValue("@Email", email);
                                    string rolead = cmd_2.ExecuteScalar().ToString();
                                    txtForPassword.Text = "";
                                    string query = "SELECT [id_user] FROM [Users] WHERE [email] = @email";
                                    SqlCommand cmd2 = new SqlCommand(query, conn);
                                    cmd2.Parameters.AddWithValue(@"email", email);
                                    int UserId = Convert.ToInt32(cmd2.ExecuteScalar());
                                    string query3 = "SELECT [id_basket] FROM [Basket] WHERE [id_user] = @IdUser";
                                    SqlCommand cmd4 = new SqlCommand(query3, conn);
                                    cmd4.Parameters.AddWithValue(@"IdUser", UserId);
                                    Basket.ID = Convert.ToInt32(cmd4.ExecuteScalar());
                                    Hide();

                                    //проверка на роль пользователя (админ или клиент)
                                    switch (rolead)
                                    {
                                        case "A":
                                            this.Hide();
                                            MenuAdmin MenuAdmin = new MenuAdmin();
                                            MenuAdmin.ShowDialog();
                                            break;
                                        case "U":
                                            SqlCommand cmd_1 = new SqlCommand(sql_3, conn);
                                            cmd_1.Parameters.AddWithValue("@Email", email);
                                            int id = Convert.ToInt32(cmd_1.ExecuteScalar());
                                            User.Email = email;
                                            this.Hide();
                                            MenuUser MenuUser = new MenuUser();
                                            MenuUser.Show();
                                            break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("К сожалению, Вы ввели неверный логин или пароль!\nПовторите ввод еще раз.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("К сожалению, Вы ввели неверный логин!\nПовторите ввод еще раз.");
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
                else
                {
                    MessageBox.Show("Введите пароль!");
                }
            }
            else
            {
                MessageBox.Show("Введите логин!");
            }
        }
    }
}
