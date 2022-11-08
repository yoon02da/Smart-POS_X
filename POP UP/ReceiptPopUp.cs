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

namespace Smart_POS_X.UI
{
    public partial class ReceiptPopUp : DevExpress.XtraEditors.XtraForm
    {
        public ReceiptPopUp()
        {
            InitializeComponent();

        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            DBHelper DB = new DBHelper();
            DataTable DT = DB.Exec($"ReceiptSelct_S01 '{txt_SellingCode.Text}'");

            gridControl1.DataSource = DT;
            gridControl2.DataSource = DT;
                 
        }
    }
}