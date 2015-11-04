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
    public partial class DeleteTicket : Form
    {
        public List<int> ticketIds { get; private set; }
        public Ticket deletedTicket { get; private set; }

        public DeleteTicket(List<Ticket> tickets)
        {
            InitializeComponent();
            ticketIds = new List<int>();
            foreach(Ticket tmpTicket in tickets)
            {
                DeleteTicketName_cmbbox.Items.Add(tmpTicket.Name);
                ticketIds.Add(tmpTicket.ID);
            }
        }

        public int getTicketId()
        {
            return ticketIds[DeleteTicketName_cmbbox.SelectedIndex];
        }

        private void DeleteTicket_btn_Click(object sender, EventArgs e)
        {
            string name = DeleteTicketName_cmbbox.Text.Trim();
            if (name != String.Empty)
            {
                deletedTicket = new Ticket(getTicketId(), name);
                DialogResult = DialogResult.OK;
                return;
            }
            else
                MessageBox.Show("Спершу введіть назву квитка, який бажаєте видалити");
        }
    }
}
