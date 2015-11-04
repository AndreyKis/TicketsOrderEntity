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
    public partial class AddNewTicket : Form
    {
        public Ticket newTicket { get; private set; }
        public List<int> priceIds { get; private set; }
        public List<int> rateIds { get; private set; }
        public List<int> typeIds { get; private set; }
        public AddNewTicket(List<Price> prices, List<Rate> rates, List<TransportType> types)
        {  
            InitializeComponent();
            priceIds = new List<int>();
            rateIds = new List<int>();
            typeIds = new List<int>();
            foreach (Price tmpPrice in prices)
            {
                Price_cmbbx.Items.Add(tmpPrice.Value);
                priceIds.Add(tmpPrice.ID);
            }
            foreach(Rate tmpRate in rates)
            {
                Rate_cmbbx.Items.Add(tmpRate.Name);
                rateIds.Add(tmpRate.ID);
            }
            foreach(TransportType tmpType in types)
            {
                Type_cmbbx.Items.Add(tmpType.Name);
                typeIds.Add(tmpType.ID);
            }
        }

        public int getPriceId()
        {
            return priceIds[Price_cmbbx.SelectedIndex];
        }

        public int getRateId()
        {
            return rateIds[Rate_cmbbx.SelectedIndex];
        }

        public int getTypeId()
        {
            return typeIds[Type_cmbbx.SelectedIndex];
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            string name = Name_txtbox.Text.Trim();
            string price = Price_cmbbx.Text.Trim();
            string rate = Rate_cmbbx.Text.Trim();
            string type = Type_cmbbx.Text.Trim();
            if (name != String.Empty && price != String.Empty &&
                rate != String.Empty && type != String.Empty)
            {
                newTicket = new Ticket(name, Int32.Parse(price), rate, type);
                DialogResult = DialogResult.OK;
                return;
            }
                MessageBox.Show("Не все поля указаны");
                return;
        }

    }
}