using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Services.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Xpo.DB.DataStoreLongrunnersWatch;

namespace Smart_POS_X.UI
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {

        DataTable DT = new DataTable();
        public Login()
        {
            InitializeComponent();
            IP.Visible = false;
            simpleButton1.Visible = false;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DBHelper DB = new DBHelper();
            DB.Exec($"Login_LoginUser '{txt_ID.Text}' ,'{txt_Password.Text}'");

            if (DB.result == false)
            {
                MessageBox.Show("ID, 비밀번호를 재확인 해주십시오.");
                return;
            }

            this.Visible = false;
            OrderScreen order = new OrderScreen();
            order.ShowDialog();
            this.Visible = true;
            
            DB.DBSend();
        }

        private void btn_Cancel_Click(object sender, EventArgs e) =>this.Close();

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            DBHelper DB = new DBHelper();
            DB.Exec($"Login_LoginUser '{txt_ID.Text}' ,'{txt_Password.Text}'");

            if (DB.result == false)
            {
                MessageBox.Show("ID, 비밀번호를 재확인 해주십시오.");
                return;
            }


            AdminScreen admin = new AdminScreen();
            if(admin.ShowDialog() == DialogResult.OK)
            {

            }
            
            //관리자 화면으로 이동
        }

        private void IPset_Click(object sender, EventArgs e)
        {
            DBHelper DB = new DBHelper();

            if (DB.DBCheckConnection() == false) {
                IP.Visible = true;
                simpleButton1.Visible = true;
            }

            MessageBox.Show($"지금 연결된 DB : {DBHelper.IP}");
        }

        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DBHelper DB = new DBHelper();
            DBHelper.IP = IP.Text;
            DB.DBCheckConnection();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.EditValue.ToString() == "True") {
                DevExpress.UserSkins.BonusSkins.Register(); 
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Dark"; 
            }

            if (toggleSwitch1.EditValue.ToString() == "False")
            {
                DevExpress.UserSkins.BonusSkins.Register();
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Blue";
            }
        }
    }
}