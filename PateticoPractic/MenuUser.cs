using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PateticoPractic
{
    public partial class MenuUser : Form
    {
        // метод, который инициализирует все компоненты, расположенные на форме
        public MenuUser() => InitializeComponent();

        //выход из приложения
        private void picExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //закрытие данной формы и переход к форме категорий товаров
        private void roundBtnCatalog_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Categoryes Categoryes = new Categoryes()
            { 
            Visible = true,
            ShowInTaskbar = true
           };
        }

        //закрытие данной формы и переход к форме информации о магазине
        private void labelAbout_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            About About = new About()
            {
                Visible = true,
                ShowInTaskbar = true
            };
        }

        //закрытие данной формы и переход к форме авторизации
        private void picUser_Click(object sender, EventArgs e)
        {           
            string message = $"Вы действительно хотите выйти из своей учетной записи?";
            string caption = "Выход из системы";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                GC.Collect();
                Authorization Authorization = new Authorization()
                {
                    Visible = true,
                    ShowInTaskbar = true
                };
            }
            else
            {
                MessageBox.Show("Мы рады, что Вы остались с нами! :)");
            }
        }

        //закрытие данной формы и переход к форме категорий товаров
        private void labelProducts_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Categoryes Categoryes = new Categoryes()
            {
                Visible = true,
                ShowInTaskbar = true
            };
        }

        //закрытие данной формы и переход к форме отзывов покупателей
        private void labelReviews_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Reviews Reviews = new Reviews()
            {
                Visible = true,
                ShowInTaskbar = true
            };
        }
        
        //закрытие данной формы и переход к форме корзины
        private void picBasket_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            BasketForm basketForm = new BasketForm();
            basketForm.Show();
        }

    }
}
