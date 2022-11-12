using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting.Export;
using Smart_POS_X.POP_UP;
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
        DBHelper DB = new DBHelper();
        DataTable DT1 = new DataTable();   
        
        DataTable dataTable = new DataTable();   
        public ReceiptPopUp()
        {
            InitializeComponent();

            dataTable = DB.SQL($"with AA as (SELECT MAX(SellingCode) as MenuName, " +
                $"sum(SellingPrice) as SellingPrice, max(SellingCount) as SellingCount, " +
                $"min(CreateTime) as CreateTime FROM POSSellRecord GROUP BY SellingCode, " +
                $"CONVERT(char(10), CreateTime, 23)) select* from AA order by AA.CreateTime");

            gridControl1.DataSource = dataTable;
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            DB.Exec($"ReceiptSelct_S03 '{txt_SellingCode.Text}'");

            if (DB.result == true)
            {

                DT1 = DB.Exec($"ReceiptSelct_S01 '{txt_SellingCode.Text}'");
                DataTable DT2 = DB.Exec($"ReceiptSelct_S02 '{txt_SellingCode.Text}'");

                gridControl1.DataSource = DT1;
                gridControl2.DataSource = DT2;
            }
            else
                MessageBox.Show("영수증 번호 오류입니다.");
        }

        private void btn_ReInput_Click(object sender, EventArgs e)
        {
            txt_SellingCode.Text = string.Empty;

            ((DataTable)gridControl1.DataSource).Clear();
            ((DataTable)gridControl2.DataSource).Clear();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ReceiptCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("환불을 진행하시겠습니까?", "환불알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //환불 로직
                DB.Exec($"refund_CUD '{selectrow.Field<string>("d")}'");



            }
            else
            {

            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DB.Exec($"ReceiptSelct_S03 '{txt_SellingCode.Text}'");

            if (DB.result == true)
            {
                this.Close();
                ReceiptPrintPopUp print = new ReceiptPrintPopUp();
                print.i = txt_SellingCode.Text;
                if (print.ShowDialog() == DialogResult.OK)
                {
                    
                }            
            }
            else
                MessageBox.Show("영수증 번호 오류입니다.");

        }
        DataRow selectrow;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            dataTable.AcceptChanges();
            if (dataTable.Rows.Count == 0) return;
            selectrow = ((DataRowView)((ColumnView)sender).FocusedRowObject).Row;
        }
    }
}