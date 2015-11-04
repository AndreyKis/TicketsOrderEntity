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
    public partial class DeleteOrder : Form
    {
        public Order deletedOrder { get; private set; }
        //public List<int> personNameIds { get; private set; }
        //public List<int> ticketNameIds { get; private set; }
        public DateTime givingDate { get; private set; }

        public DeleteOrder(List<Order> allOrders, List<Ticket> allTickets)
        {
            InitializeComponent();
            /*personNameIds = new List<int>();
            ticketNameIds = new List<int>();*/
            foreach(Order tmpOrder in allOrders)
            {
                if (!DeleteTOrderPrsnName_cmbbox.Items.Contains(tmpOrder.PersonName))
                {
                    DeleteTOrderPrsnName_cmbbox.Items.Add(tmpOrder.PersonName);
                    //personNameIds.Add(tmpOrder.ID);
                }

            }
            foreach(Order tmpOrder in allOrders)
            {
                if (!DeleteOrdrTickName_cmbbox.Items.Contains(tmpOrder.TicketName))
                {
                    DeleteOrdrTickName_cmbbox.Items.Add(tmpOrder.TicketName);
                    //ticketNameIds.Add(tmpOrder.ID);
                }
            }
        }

        /*public int GetTicketNameId ()
        {
            return ticketNameIds[DeleteOrdrTickName_cmbbox.SelectedIndex];
        }

        public int GetPersonNameId()
        {
            return personNameIds[DeleteTOrderPrsnName_cmbbox.SelectedIndex];
        }*/

        private void DeleteOrder_btn_Click(object sender, EventArgs e)
        {
            givingDate = new DateTime();
            try
            {
                givingDate = Convert.ToDateTime(DeleteOrdrDate_txtbox.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Неправильно введені дані в поле дати. Спробуйте формат dd.mm.yyyy");
                return;
            }
            string personName = DeleteTOrderPrsnName_cmbbox.Text.Trim();
            string ticketName = DeleteOrdrTickName_cmbbox.Text.Trim();
            deletedOrder = new Order(0, personName, ticketName, givingDate, 0, 0);
            DialogResult = DialogResult.OK;
            return;
        }
    }
}
