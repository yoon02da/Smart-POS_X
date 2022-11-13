using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting.Export;
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
    public partial class MemberSelectPopUp : DevExpress.XtraEditors.XtraForm
    {
        DBHelper DB = new DBHelper();
        DataTable DT1 = new DataTable();
        DataTable DT2 = new DataTable();
        public DataRow dataRowSelect = null;
        public DialogResult res;
        public string SellingCode { get; set; } 

        public MemberSelectPopUp()
        {
            InitializeComponent();
        }

        private void btn_MemJoin_Click(object sender, EventArgs e)
        {
            MemberJoinPopUp joinPopUp = new MemberJoinPopUp();

            if (joinPopUp.ShowDialog() == DialogResult.OK)
            {

            }
        }
        DataRow datarow;
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            DT1 = DB.Exec($"MemberSelect_S01 '{txt_num.Text}'");

            //gridControl2.DataSource = DT2;

            gridControl1.DataSource = DT1;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            dataRowSelect = datarow;
            res = DialogResult.OK;


            this.Close();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //DT1.AcceptChanges();
            //if (DT1.Rows.Count == 0) return;
            //datarow = ((DataRowView)((ColumnView)sender).FocusedRowObject).Row;
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            DT1.AcceptChanges();
            if (DT1.Rows.Count == 0) return;
            datarow = ((DataRowView)((ColumnView)sender).FocusedRowObject).Row;



            if(datarow == null)return;

            SellingCode = datarow.Field<string>("MemberCode");
            gridControl2.DataSource = DB.Exec($"MemberSelect_S03 '{SellingCode}'");
             
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
         //   dataRowSelect = datarow;
         //   this.Close();
        }
    }
}