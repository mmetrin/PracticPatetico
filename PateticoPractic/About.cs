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
    public partial class About : Form
    {
        //метод, который инициализирует все компоненты, расположенные на форме
        public About() => InitializeComponent();

        //выход из приложения
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //вызов метода для перехода к форме меню клиента            
        private void picArrowBack_Click(object sender, EventArgs e)
        {
            backToManu();
        }

        //вызов метода для перехода к форме меню клиента      
        private void labelBack_Click(object sender, EventArgs e)
        {
            backToManu();
        }

        //метод для перехода к форме меню клиента 
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

        //переход к форме категорий товаров
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
    }
}
