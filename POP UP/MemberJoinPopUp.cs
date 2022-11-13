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

        public string MemberName { get; set; }
        public string MemberPhoneNumber { get; set; }
        public string PresentPoint { get; set;}
        public string CumulativePoint { get; set; }
        public DataTable DataTable { get; set;}
        public MemberJoinPopUp()
        {
            InitializeComponent();
        }

        private void btn_Join_Click(object sender, EventArgs e)
        {
            DataTable = DB.Exec($"MemberJoin_I01 '{txt_MemName.Text}','{txt_PhoneNum.Text}'");

            if (DataTable.Rows.Count == 1)
            {
                gridControl1.DataSource = DataTable;
            }
            else
            {

                if (DataTable.Rows[0][0].ToString() == "ER")
                    MessageBox.Show("중복고객이 있습니다.");
                DataTable.Clear();
                gridControl1.DataSource = DataTable;
            } 
             
        }
           
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ReInput_Click(object sender, EventArgs e)
        {
            txt_MemName.Text = string.Empty;
            txt_PhoneNum.Text = string.Empty;

        }
    }
}