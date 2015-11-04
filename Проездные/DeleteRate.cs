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
    public partial class DeleteRate : Form
    {
        public List<int> rateIds { get; private set; }
        public Rate deletedRate { get; private set; }

        public DeleteRate(List<Rate> allRates)
        {
            InitializeComponent();
            rateIds = new List<int>();
            foreach(Rate tmpRate in allRates)
            {
                DeleteRateName_cmbbox.Items.Add(tmpRate.Name);
                rateIds.Add(tmpRate.ID);
            }
        }

        public int getRateId()
        {
            return rateIds[DeleteRateName_cmbbox.SelectedIndex];
        }

        private void DeleteRate_btn_Click(object sender, EventArgs e)
        {
            string name = DeleteRateName_cmbbox.Text.Trim();
            if (name != String.Empty)
            {
                deletedRate = new Rate(getRateId(), name);
                DialogResult = DialogResult.OK;
                return;
            }
            else
                MessageBox.Show("Спершу введіть значення кількості, яку бажаєте видалити");
        }
    }
}
