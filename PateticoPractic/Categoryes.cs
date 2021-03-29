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
    public partial class Categoryes : Form
    {
        //инициализация типа категории для дальнейшего перехода на последнюю закрытую форму
        static public Product product;
        public struct Product
        {
            public int type;
        }

        //метод, который инициализирует все компоненты, расположенные на форме
        public Categoryes() => InitializeComponent();

        //закрытие приложения
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //закрытие данной формы и переход к форме отзывов
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

        //закрытие данной формы и переход к форме инфо о магазине
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

        //осуществление выхода из учетной записи
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

        //закрытие данной формы и переход к форме категории товаров торты и кексы
        private void roundBtnCakes_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            product.type = 1;
            ProductCake ProductCake = new ProductCake()
            {
                Visible = true,
                ShowInTaskbar = true
            };
        }

        //закрытие данной формы и переход к форме категории товаров шоколад
        private void roundBtnChoko_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            product.type = 2;
            ProductChocolate productChocolate = new ProductChocolate();
            productChocolate.Show();
        }

        //закрытие данной формы и переход к форме категории товаров пирожные
        private void roundBtnSweet_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            product.type = 3;
            ProductPanCakes productPanCakes = new ProductPanCakes();
            productPanCakes.Show();
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
