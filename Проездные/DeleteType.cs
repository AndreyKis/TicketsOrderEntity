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
    public partial class DeleteType : Form
    {
        public List<int> typeIds { get; private set; }
        public TransportType deletedType { get; private set; }

        public DeleteType(List<TransportType> alltypes)
        {
            InitializeComponent();
            typeIds = new List<int>();
            foreach(TransportType tmpType in alltypes)
            {
                DeleteTypeName_cmbbox.Items.Add(tmpType.Name);
                typeIds.Add(tmpType.ID);
            }
        }

        public int getTypeId()
        {
            return typeIds[DeleteTypeName_cmbbox.SelectedIndex];
        }

        private void DeleteType_btn_Click(object sender, EventArgs e)
        {
            string name = DeleteTypeName_cmbbox.Text.Trim();
            if (name != String.Empty)
            {
                deletedType = new TransportType(getTypeId(), name);
                DialogResult = DialogResult.OK;
                return;
            }
            else
                MessageBox.Show("Спершу введіть значення типу, який бажаєте видалити");
        }
    }
}
