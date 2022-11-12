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
    public partial class MemberSelectPopUp : DevExpress.XtraEditors.XtraForm
    {
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
    }
}