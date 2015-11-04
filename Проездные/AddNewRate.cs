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
    public partial class AddNewRate : Form
    {
        public Rate newRate { get; private set; }

        public AddNewRate()
        {
            InitializeComponent();
        }

        private void AddRate_btn_Click(object sender, EventArgs e)
        {
            string name = NewRateValue_txtbox.Text.Trim();
            if (name != String.Empty)
            {
                newRate = new Rate(name);
                DialogResult = DialogResult.OK;
                return;
            }
            else
                MessageBox.Show("Спершу введіть якесь значення ціни");
        }
    }
}
