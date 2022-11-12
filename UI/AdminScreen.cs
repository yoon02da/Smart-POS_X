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
    public partial class AdminScreen : DevExpress.XtraEditors.XtraForm
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {

            Padding Empty = new Padding(80);
            accordionControl1.Margin = Empty;
            
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAco_Emp_Click(object sender, EventArgs e)
        {
            EmpManagedScreen empManagedScreen = new EmpManagedScreen();
            
            if(empManagedScreen.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnAco_Menu_Click(object sender, EventArgs e)
        {

        }
    }
}