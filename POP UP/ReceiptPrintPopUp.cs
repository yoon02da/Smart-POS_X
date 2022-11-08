using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Animation;
using Smart_POS_X.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_POS_X.POP_UP
{
    public partial class ReceiptPrintPopUp : DevExpress.XtraEditors.XtraForm
    {
        public string i { get; set; }
        public ReceiptPrintPopUp()
        {
            InitializeComponent();

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReceiptPrintPopUp_Load(object sender, EventArgs e)
        {
            lbl_SellingCode.Text = i;
        }
    }
}