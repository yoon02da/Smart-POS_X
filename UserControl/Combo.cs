using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_POS_X.UserControl
{
    public partial class Combo : DevExpress.XtraEditors.XtraUserControl
    {
        public string Code {get; set;}
        public Combo()
        {
            InitializeComponent();

            this.cbo.Properties.DisplayMember = "NAME";
            this.cbo.Properties.ValueMember = "CODE";
            this.cbo.Properties.NullText = "";
            
        }

        private void cbo_Properties_EditValueChanged(object sender, EventArgs e)
        {
            Code = this.cbo.EditValue.ToString() ?? "-999";
        }

        private void Combo_Load(object sender, EventArgs e)
        {

        }

        private void lookUpEdit1_Properties_DataSourceChanged(object sender, EventArgs e)
        {
            DataTable dt = ((DataTable)cbo.Properties.DataSource);
            this.cbo.Properties.DropDownRows = dt.Rows.Count;
            this.cbo.EditValue = "-999";
        }

        private void lookUpEdit1_Properties_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Code = this.cbo.EditValue.ToString() ?? "-999";
        }
    }
}
