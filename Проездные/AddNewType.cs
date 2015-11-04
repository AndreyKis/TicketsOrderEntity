using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Common;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проездные
{
    public partial class AddNewType : Form
    {
        public TransportType newType { get; private set; }

        public AddNewType()
        {
            InitializeComponent();
        }

        private void AddType_btn_Click(object sender, EventArgs e)
        {
            string name = NewTypeName_txtbox.Text.Trim();
            if (name != String.Empty)
            {
                newType = new TransportType(name);
                DialogResult = DialogResult.OK;
                return;
            }
            else
                MessageBox.Show("Введіть назву нового типу");
        }
    }
}
