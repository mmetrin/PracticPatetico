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
    public partial class MenuAdmin : Form
    {
        // метод, который инициализирует все компоненты, расположенные на форме
        public MenuAdmin() => InitializeComponent();

        //выход из приложения
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //закрытие данной формы и переход к форме авторизации
        private void picArrawBack_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Authorization Authorization = new Authorization();
            Authorization.Visible = true;
            Authorization.ShowInTaskbar = true;
        }

        //закрытие данной формы и переход к форме категорий товаров
        private void roundBtnCategory_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Parameters Parameters = new Parameters();
            Parameters.Visible = true;
            Parameters.ShowInTaskbar = true;
        }

        //закрытие данной формы и переход к форме списка товаров
        private void roundBtnSweets_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            ProductsAdmin ProductsAdmin = new ProductsAdmin();
            ProductsAdmin.Visible = true;
            ProductsAdmin.ShowInTaskbar = true;
        }

        //закрытие данной формы и переход к форме списка магазинов
        private void roundBtnShops_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Shops Shops = new Shops();
            Shops.Visible = true;
            Shops.ShowInTaskbar = true;
        }

        //закрытие данной формы и переход к форме списка заказов
        private void roundBtnOrders_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
            Orders Orders = new Orders();
            Orders.Visible = true;
            Orders.ShowInTaskbar = true;
        }
    }
}
