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
    public partial class DeletePerson : Form
    {
        public List<int> personIds { get; private set; }
        public Person deletedPerson { get; private set; }

        public DeletePerson(List<Person> allPersons)
        {
            InitializeComponent();
            personIds = new List<int>();
            foreach (Person tmpPerson in allPersons)
            {
                DeletePersonName_cmbbox.Items.Add(tmpPerson.Name);
                personIds.Add(tmpPerson.ID);
            }
        }

        public int getPersonId()
        {
            return personIds[DeletePersonName_cmbbox.SelectedIndex];
        }

        private void DeletePerson_btn_Click(object sender, EventArgs e)
        {
            string name = DeletePersonName_cmbbox.Text.Trim();
            if (name != String.Empty)
            {
                deletedPerson = new Person(getPersonId(), name);
                DialogResult = DialogResult.OK;
                return;
            }
            else
                MessageBox.Show("Спершу введіть ім'я людини, яке бажаєте видалити");
        }
    }
}
