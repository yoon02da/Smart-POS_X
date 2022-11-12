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

namespace Smart_POS_X.POP_UP
{
    public partial class MemberJoinPopUp : DevExpress.XtraEditors.XtraForm
    {
        DBHelper DB = new DBHelper();
        DataTable DT1 = new DataTable();

        DataTable dataTable = new DataTable();

        public MemberJoinPopUp()
        {
            InitializeComponent();
        }

        private void btn_Join_Click(object sender, EventArgs e)
        {

        }
    }
}