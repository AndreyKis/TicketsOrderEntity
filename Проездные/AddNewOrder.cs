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
    public partial class AddNewOrder : Form
    {
        public Order newOrder { get; private set; }
        public List<int> personsIds { get; private set; }
        public List<int> ticketsIds { get; private set; }

        public AddNewOrder(List<Person> persons, List<Ticket> tickets)
        {
            InitializeComponent();
            personsIds = new List<int>();
            ticketsIds = new List<int>();
            foreach(Person tmpPerson in persons)
            {
                PersonNames_cmbbox.Items.Add(tmpPerson.Name);
                personsIds.Add(tmpPerson.ID);
            }
            foreach(Ticket tmpTicket in tickets)
            {
                TicketNames_cmbbox.Items.Add(tmpTicket.Name);
                ticketsIds.Add(tmpTicket.ID);
            }
        }

        public int getPersonId()
        {
            return personsIds[PersonNames_cmbbox.SelectedIndex];
        }

        public int getTicketId()
        {
            return ticketsIds[TicketNames_cmbbox.SelectedIndex];
        }

        private void AddOrder_btn_Click(object sender, EventArgs e)
        {
            string personName = PersonNames_cmbbox.Text.Trim();
            string ticketName = TicketNames_cmbbox.Text.Trim();
            string givingDate = GivingDate_txtbox.Text.Trim();
            string amount = TickAmount_txtbox.Text.Trim();
            string pledge = Pledge_txtbox.Text.Trim();
            if (personName != String.Empty && ticketName != String.Empty &&
                givingDate != String.Empty && amount != String.Empty)
            {
                DateTime givDate = new DateTime();
                int tAm = 0;
                int pl = 0;
                try
                {
                    givDate = Convert.ToDateTime(GivingDate_txtbox.Text.Trim());
                }
                catch 
                {
                    MessageBox.Show("Неправильно введені дані в поле Дати здачі грошей. Спробуйте формат dd.mm.yyyy");
                    return;
                }
                try 
                {
                    tAm = Convert.ToInt32(TickAmount_txtbox.Text.Trim());
                    if (pledge != String.Empty)
                        pl = Convert.ToInt32(Pledge_txtbox.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Вибачте, але в поля кількості квитків та боргу бажано вводити цифри");
                    return;
                }
                newOrder = new Order(personName, ticketName, givDate, 
                    tAm, pl);
                DialogResult = DialogResult.OK;
                return;
            }
            MessageBox.Show("Не все поля указаны");
            return;
        }
    }
}
