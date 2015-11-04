using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Проездные
{
    public partial class AddNewPrice : Form
    {
        public Price newPrice { get; private set; }

        public AddNewPrice()
        {
            InitializeComponent();
        }

        private void AddPrice_btn_Click(object sender, EventArgs e)
        {
            string name = NewPriceValue_txtbox.Text.Trim();
            int value = 0;
            try
            {    
                value = Convert.ToInt32(name);    
            }    
            catch
            {
                MessageBox.Show("Спершу введіть якесь значення ціни");
                return;
            }
            if (name != String.Empty && value >= 0)
            {
                newPrice = new Price(value);
                DialogResult = DialogResult.OK;
                return;
            }
            else if (name == String.Empty)
                MessageBox.Show("Введіть хоча б якесь значення ціни");
            else
                MessageBox.Show("Значення ціни не може бути від'ємним");
        }
    }
}
