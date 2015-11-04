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
    public partial class DeletePrice : Form
    {
        public List<int> priceIds { get; private set; }
        public Price deletedPrice { get; private set; }
        public DeletePrice(List<Price> prices)
        {
            InitializeComponent();
            priceIds = new List<int>();
            foreach (Price tmpPrice in prices)
            {
                DeletePriceName_cmbbox.Items.Add(tmpPrice.Value);
                priceIds.Add(tmpPrice.ID);
            }
        }

        public int getPriceId()
        {
            return priceIds[DeletePriceName_cmbbox.SelectedIndex];
        }

        private void DeletePrice_btn_Click(object sender, EventArgs e)
        {
            string name = DeletePriceName_cmbbox.Text.Trim();
            int value = 0;
            try { value = Convert.ToInt32(name);}
            catch { MessageBox.Show("Спершу видаліть значення ціни, яку бажаєте видалити"); }
            if (name != String.Empty)
            {
                deletedPrice = new Price(getPriceId(), value);
                DialogResult = DialogResult.OK;
                return;
            }
        }
    }
}
