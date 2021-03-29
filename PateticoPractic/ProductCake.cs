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
    public partial class ProductCake : Form
    {
        // метод, который инициализирует все компоненты, расположенные на форме
        public ProductCake() => InitializeComponent();

        //выход из приложения
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        

        private void labelInfoCake1_Click(object sender, EventArgs e)
        {
            //вызов метода перехода к форме подробностей о товаре id=2002
            goToInfoProduct(2002);
        }      
       
        private void labelInfoCake4_Click(object sender, EventArgs e)
        {
            //вызов метода перехода к форме подробностей о товаре
            goToInfoProduct(2004);
        }

        private void labelInfoCake5_Click(object sender, EventArgs e)
        {
            //вызов метода перехода к форме подробностей о товаре
            goToInfoProduct(5);
        }

        private void labelInfoCake6_Click(object sender, EventArgs e)
        {
            //вызов метода перехода к форме подробностей о товаре
            goToInfoProduct(9);
        }

        private void labelInfoCake3_Click(object sender, EventArgs e)
        {
            //вызов метода перехода к форме подробностей о товаре
            goToInfoProduct(10);
        }

        private void labelInfoCake2_Click(object sender, EventArgs e)
        {
            //вызов метода перехода к форме подробностей о товаре
            goToInfoProduct(2003);
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            //вызов метода перехода к форме категорий
            backToCategory();
        }

        private void picArrowBack_Click(object sender, EventArgs e)
        {
            //вызов метода перехода к форме категорий
            backToCategory();
        }

        //метод перехода к форме категорий
        private void backToCategory()
        {            
        this.Close();
        GC.Collect();
            Categoryes Categoryes = new Categoryes()
            {
                Visible = true,
                ShowInTaskbar = true
            };
        }

        //метод перехода к форме подробностей о товаре по определенному id
        private void goToInfoProduct(int id)
        {
            this.Close();
            GC.Collect();
            InfoProduct InfoProduct = new InfoProduct(id)
            {
                Visible = true,
                ShowInTaskbar = true
            };
        }       
    }
}
