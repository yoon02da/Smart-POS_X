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
            //로그인 ID 검증 후
            //다음 메뉴
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
            =>this.Close();
        

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            //관리자 화면으로 이동
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}