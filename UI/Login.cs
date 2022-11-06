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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            OrderScreen order = new OrderScreen();
            if(order.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
            =>this.Close();
        

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            AdminScreen admin = new AdminScreen();
            if(admin.ShowDialog() == DialogResult.OK)
            {

            }
            
            //관리자 화면으로 이동
        }

    }
}