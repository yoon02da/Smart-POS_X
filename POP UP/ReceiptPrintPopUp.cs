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

            DBHelper DB = new DBHelper();
            DB.Exec($"ReceiptSelct_S03 '{lbl_SellingCode.Text}'");

            if (DB.result == true)
            {

                DataTable DT1 = DB.Exec($"ReceiptSelct_S01 '{lbl_SellingCode.Text}'");
                DataTable DT2 = DB.Exec($"ReceiptSelct_S02 '{lbl_SellingCode.Text}'");

                gridControl1.DataSource = DT1;
                gridControl2.DataSource = DT2;
            }
            else
                MessageBox.Show("영수증 번호 오류입니다.");
        }
    }
}