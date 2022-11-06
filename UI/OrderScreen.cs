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
using static Smart_POS_X.Enum;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Smart_POS_X.UI
{
    public partial class OrderScreen : DevExpress.XtraEditors.XtraForm
    {
        private int MenuSelect {get; set;}
        private MenuList MenuSelecter { get; set; }
        public OrderScreen()
        {
            InitializeComponent();
            Menu_reset();

        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            MenuSelecter = MenuList.COFFEE;
            Menu_Setting();
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            MenuSelecter = MenuList.NON_COFFEE;
            Menu_Setting();
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            MenuSelecter = MenuList.SMOOTHIE;
            Menu_Setting();
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            MenuSelecter = MenuList.Dessert;
            Menu_Setting();
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            MenuSelecter = MenuList.ETC;
            Menu_Setting();
        }

        private void Menu_Setting()
        {
            DBHelper DBh = new DBHelper();
            //이넘을 이용해 해당 객채들을 소환하고.. \


            DataTable DT = DBh.Exec($"OrderScreen_S01 '{MenuSelecter.ToString().ToUpper()}'"); // 1.커피,2.논커피,3.스무디,4.샌드위치,5.기타.
                                                                                               //메뉴순번 , 메뉴 이름 받아야함
            Menu_reset();

            foreach (SimpleButton control in tablePanel6.Controls) 
            {
                if (control == null) continue;
                foreach (DataRow DR in DT.Rows) {
                    if (control.Name.ToString() == DR[0].ToString())
                        control.Text = DR[1].ToString();
                }
            }


        }

        private void Menu_reset()
        {
            foreach (SimpleButton control in tablePanel6.Controls)
            {
                if (control.Name.Contains("Menu"))
                    control.Text = "-";
            }
        }

    }
}