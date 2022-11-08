using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting.Export;
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

      //  public int FocuseTextBox

        DataTable MenuTable = new DataTable();
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

        private void btn_POS_End_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            string MenuName = ((DevExpress.Accessibility.BaseAccessibleObject)((System.Windows.Forms.Control)sender).AccessibilityObject).Name;
            if (MenuName == "-") return;

            DBHelper DBh = new DBHelper();
            DataTable DT = DBh.Exec($"OrderScreen_S02 '{MenuName}'");

            int AllAmount = 0;

            if (AddMenu(DT.Rows[0]["Menu"].ToString())) //같은 메뉴가 있는경우 거짓
            {
                lbl_AllAmount.Text = AllAmount.ToString();
                MenuTable.Merge(DT);
                gridControl1.DataSource = MenuTable;
            }
           
            AllMountCal();
        }

        private bool AddMenu(string MenuNameTemp) {
            foreach (DataRow DR in MenuTable.Rows)
            {
                if (MenuNameTemp == DR["Menu"].ToString())
                {
                    int QTYNUM = Int32.Parse(DR["QTY"].ToString());
                    int PriceNUM = Int32.Parse(DR["ORG_Price"].ToString());
                    DR["QTY"] = ++QTYNUM;
                    DR["Price"] = QTYNUM * PriceNUM;

                    gridControl1.DataSource = MenuTable;
                    return false;
                }
            }
            return true;
        }

        private void AllMountCal() 
        {
            int AllAmount = 0;
            foreach (DataRow DR in MenuTable.Rows)
            {
                int PriceSUM = Int32.Parse(DR["Price"].ToString());
                AllAmount += PriceSUM;
            }

            lbl_AllAmount.Text = AllAmount.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string Num = ((DevExpress.Accessibility.BaseAccessibleObject)((System.Windows.Forms.Control)sender).AccessibilityObject).Name;
        }

        private void textEdit1_Properties_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ReceipeSelect_Click(object sender, EventArgs e)
        {
            ReceiptPopUp receipt = new ReceiptPopUp();

            if (receipt.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}