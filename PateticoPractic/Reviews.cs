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
    public partial class Reviews : Form
    {
        // метод, который инициализирует все компоненты, расположенные на форме
        public Reviews() => InitializeComponent();
        
        //закрытие данной формы и переход на форму категорий товаров
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
        

        //вызов метода на закрытие данной формы и переход к форме меню клиента 
        private void picArrowBack_Click(object sender, EventArgs e)
        {
            backToManu();
        }

        //вызов метода на закрытие данной формы и переход к форме меню клиента 
        private void labelBack_Click(object sender, EventArgs e)
        {
            backToManu();
        }
        
        //метод на закрытие данной формы и переход к форме меню клиента 
        private void backToManu()
        {
            this.Close();
            GC.Collect();
            MenuUser MenuUser = new MenuUser()
            {
                Visible = true,
                ShowInTaskbar = true
            };
        }
    }
}
