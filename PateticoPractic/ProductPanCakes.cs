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
    public partial class ProductPanCakes : Form
    {
        // метод, который инициализирует все компоненты, расположенные на форме
        public ProductPanCakes() => InitializeComponent();

        //вызов метода перехода к форме категорий
        private void labelBack_Click(object sender, EventArgs e)
        {
            backToCategory();
        }
     
        //вызов метода перехода к форме категорий
        private void picArrowBack_Click(object sender, EventArgs e)
        {
            backToCategory();
        }

        //метод перехода к форме категорий и закрытия данной формы
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

        private void labelInfoCake1_Click(object sender, EventArgs e)
        {
            //вызов метода перехода к форме подробностей о товаре id=8
            goToInfoProduct(8);
        }

        private void labelInfoCake2_Click(object sender, EventArgs e)
        {
            //вызов метода перехода к форме подробностей о товаре id=2005
            goToInfoProduct(2005);
        }

        private void labelInfoCake3_Click(object sender, EventArgs e)
        {
            //вызов метода перехода к форме подробностей о товаре id=2006
            goToInfoProduct(2006);
        }

        private void labelInfoCake4_Click(object sender, EventArgs e)
        {
            //вызов метода перехода к форме подробностей о товаре id=2007
            goToInfoProduct(2007);
        }

        private void labelInfoCake5_Click(object sender, EventArgs e)
        {
            //вызов метода перехода к форме подробностей о товаре id=2008
            goToInfoProduct(2008);
        }

        private void labelInfoCake6_Click(object sender, EventArgs e)
        {
            //вызов метода перехода к форме подробностей о товаре id=2009
            goToInfoProduct(2009);
        }
    }
}
