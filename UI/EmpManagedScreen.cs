using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.Design;
using Smart_POS_X.UserControl;
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

    public partial class EmpManagedScreen : DevExpress.XtraEditors.XtraForm
    {
        DBHelper DB = new DBHelper();
        public EmpManagedScreen()
        {
            InitializeComponent();

            Combo();
        }

        private void EmpManagedScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            DB.Exec($"EmpManagedScreen_S01 '{txt_EmpCode.Text}', '{cbo_Job.Code}', '{cbo_WorkGroup.Code}', '{cbo_WorkState.Code}'");

            if (DB.result == true)
            {

                //DataTable DT1 = DB.Exec($"ReceiptSelct_S01 '{txt_EmpCode.Text}', '{cbo_Job.Text}', '{cbo_WorkGroup.Text}', '{cbo_WorkState.Text}'");

                //gridControl1.DataSource = DT1;
            }

        }

        private void Combo()
        {

            DBHelper DB = new DBHelper();

            cbo_Job.cbo.Properties.DataSource = DB.Exec($"CODE_SELECT '직급','Y'");
            cbo_WorkGroup.cbo.Properties.DataSource = DB.Exec($"CODE_SELECT '근무조','Y'");
            cbo_WorkState.cbo.Properties.DataSource = DB.Exec($"CODE_SELECT '근무상태','Y'");

            cbo_Job.cbo.Properties.DisplayMember = "NAME";
            cbo_WorkGroup.cbo.Properties.DisplayMember = "NAME";
            cbo_WorkState.cbo.Properties.DisplayMember = "NAME";
        }
    }
}