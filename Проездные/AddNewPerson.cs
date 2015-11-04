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
    public partial class AddNewPerson : Form
    {
        public Person newPerson;

        public AddNewPerson()
        {
            InitializeComponent();
        }

        private void AddPerson_btn_Click(object sender, EventArgs e)
        {
            string name = NewPersonName_txtbox.Text.Trim();
            string enter = NewPersonEntDate_txtbox.Text.Trim();
            string grad = NewPersonEndDate_txtbox.Text.Trim();
            DateTime enterDateTime = new DateTime();
            DateTime gradDateTime = new DateTime();
            if (name != String.Empty && enter != String.Empty && grad != String.Empty)
            {
                try
                {
                    enterDateTime = Convert.ToDateTime(enter);
                    gradDateTime = Convert.ToDateTime(grad);
                    newPerson = new Person(name, enterDateTime, gradDateTime);
                    DialogResult = DialogResult.OK;
                    return;
                }
                catch
                {
                    MessageBox.Show("Неправильно введені дати, спробуйте ввести у форматі dd.mm.yyyy");
                }
                
            }
            else
                MessageBox.Show("Не всі поля введені");
        }
    }
}
