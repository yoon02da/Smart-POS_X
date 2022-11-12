using DevExpress.Charts.Native;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraPrinting.Export;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using static Smart_POS_X.Enum;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DevExpress.BarCodes;

namespace Smart_POS_X.UI
{
    public partial class OrderScreen : DevExpress.XtraEditors.XtraForm
    {
        DBHelper DB = new DBHelper();
        private MenuList MenuSelecter { get; set; }
        private SelectSwitch SelectSwitch { get; set; }
        DataRow selectedrow = null;
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
            DataTable DT = DB.Exec($"OrderScreen_S01 '{MenuSelecter.ToString().ToUpper()}'"); // 1.커피,2.논커피,3.스무디,4.샌드위치,5.기타.
                                                                                               //메뉴순번 , 메뉴 이름 받아야함
            Menu_reset();

            foreach (SimpleButton control in tablePanel6.Controls)
            {
                if (control == null) continue;
                foreach (DataRow DR in DT.Rows)
                    if (control.Name.ToString() == DR[0].ToString())
                        control.Text = DR[1].ToString();
            }
        }

        private void Menu_reset()
        {
            foreach (SimpleButton control in tablePanel6.Controls)
                if (control.Name.Contains("Menu")) control.Text = string.Empty;
        }

        private void btn_POS_End_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            string MenuName = ((DevExpress.Accessibility.BaseAccessibleObject)((Control)sender).AccessibilityObject).Name;
            if (MenuName == string.Empty) return;

            DataTable DT = DB.Exec($"OrderScreen_S02 '{MenuName}'");

            int AllAmount = 0;

            if (DT.Rows[0]["Menu"].ToString() == String.Empty) return;

            if (AddMenu(DT.Rows[0]["Menu"].ToString())) //같은 메뉴가 있는경우 거짓
            {
                lbl_AllAmount.Text = AllAmount.ToString();
                MenuTable.Merge(DT);
                gridControl1.DataSource = MenuTable;
            }
            AllMountCal();
        }

        private bool AddMenu(string MenuNameTemp)
        {
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
            switch (SelectSwitch)
            {
                case SelectSwitch.Payment:
                    KeyPadInput(textEdit1, SelectSwitch, Num);
                    break;
                case SelectSwitch.Sale:
                    KeyPadInput(textEdit2, SelectSwitch, Num);
                    break;
                case SelectSwitch.Aamount_remaining:
                    KeyPadInput(textEdit4, SelectSwitch, Num);
                    break;
                default:
                    break;
            }
        }
        private void KeyPadInput(TextEdit textEdit, SelectSwitch selectSwitch, String Num)
        {
            if (Num == "C")
            {
                if (textEdit.Text.Length == 0) return;
                textEdit.Text = textEdit.Text.Substring(0, textEdit.Text.Length - 1);
                return;
            }
            if (Num == "OK")
            {//결제금액-(할인금액+받은금액)
                if (TotalAmount() == 0)
                {
                    MessageBox.Show("결제 되었습니다.");
                    PayInvoice();
                    Reset();
                }
                else
                {
                    MessageBox.Show("실패하였습니다.");
                    return;
                }
            }
            else 
                textEdit.Text += Num;
        }

        private int? TotalAmount() 
        {
            int? All = Int32.Parse(lbl_AllAmount.Text == String.Empty ? "0" : lbl_AllAmount.Text);
            int? Payment = Int32.Parse(textEdit1.Text == String.Empty ? "0" : textEdit1.Text);
            int? Sale = Int32.Parse(textEdit2.Text == String.Empty ? "0" : textEdit2.Text);

            int? Amount_remaining = 0;
            Amount_remaining = All - (Payment + Sale);

            textEdit4.Text = Amount_remaining.ToString();

            return Amount_remaining;
        }
        private void PayInvoice()
        { //결제가 완료되는 경우.. 맴버쉽 완성시 추가..
            string SellingCode = DB.Exec($"OrderScreen_I01 '-','{textEdit1.Text}','{textEdit2.Text}','0'").Rows[0]["SEQ"].ToString();

            foreach (DataRow ROW in MenuTable.Rows)
                DB.SQL($"INSERT INTO POSSellRecord ( SellingCode ,SellingDetail ,SellingPrice ,SellingCount ,CreateUser, CreateTime) " +
                             $"VALUES ( '{SellingCode}' ,'{ROW["Menu"]}' ,'{ROW["Price"]}' ,'{ROW["QTY"]}' ,'POP',GETDATE() )");
        }
        private void Reset() {
            gridControl1.DataSource = null;

            lbl_AllAmount.Text = String.Empty;
            textEdit1.Text = String.Empty;
            textEdit2.Text = String.Empty;
            textEdit4.Text = String.Empty;

            MenuTable.Clear();
        }
        private void btn_ReceipeSelect_Click(object sender, EventArgs e)
        {
            ReceiptPopUp receipt = new ReceiptPopUp();

            if (receipt.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            SelectSwitch = SelectSwitch.Payment;
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            SelectSwitch = SelectSwitch.Sale;
        }

        private void textEdit3_Click(object sender, EventArgs e)
        {
            SelectSwitch = SelectSwitch.Aamount_received;
        }

        private void textEdit4_Click(object sender, EventArgs e)
        {
            SelectSwitch = SelectSwitch.Aamount_remaining;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            MenuTable.Clear();
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            ReceiptPopUp ReceiptPopUp = new ReceiptPopUp();
            if (ReceiptPopUp.ShowDialog() == DialogResult.OK)
            {
              

            }
        }

        private void btn_MemberShip_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void btn_ObjectMinus_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
            MenuTable.AcceptChanges();
            AllMountCal();
            TotalAmount();
        } 
        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            MenuTable.AcceptChanges();
            if (MenuTable.Rows.Count == 0) return;
            selectedrow = ((DataRowView)((ColumnView)sender).FocusedRowObject).Row;
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.pictureEdit1.Image = null;

            BarCode barCode = new BarCode();
            barCode.Symbology = Symbology.QRCode;
            barCode.CodeText = "https://www.devexpress.com/";
            barCode.BackColor = Color.White;
            barCode.ForeColor = Color.Black;
            barCode.RotationAngle = 0;
            barCode.CodeBinaryData = Encoding.Default.GetBytes(barCode.CodeText);
            barCode.Options.QRCode.CompactionMode = DevExpress.BarCodes.QRCodeCompactionMode.Byte;
            barCode.Options.QRCode.ErrorLevel = QRCodeErrorLevel.Q;
            barCode.Options.QRCode.ShowCodeText = false;
            barCode.DpiX = 72;
            barCode.DpiY = 72;
            barCode.Module = 2f;

            this.pictureEdit1.Image = barCode.BarCodeImage;

        }
    }
}