using DevExpress.BarCodes;
using DevExpress.XtraEditors;
using Smart_POS_X.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_POS_X
{
    internal class Tools
    {
        public XtraForm ControlInControl(PanelControl baseFrom, DevExpress.XtraEditors.XtraForm targetFrom) {
           // EmpManagedScreen empManagedScreen = new EmpManagedScreen();
            targetFrom.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            baseFrom.Controls.Clear();
            targetFrom.TopLevel = false;
            baseFrom.Controls.Add(targetFrom);
            targetFrom.Show();
            targetFrom.Dock = DockStyle.Fill;

            return targetFrom;
        }
        public BarCode Barcode(string context)
        {
            /*
             pictureEdit1에 바코드 이미지를 넣는 예제
             */
            BarCode barCode = new BarCode();
            barCode.Symbology = Symbology.Code39;
            barCode.CodeText = context;
            barCode.BackColor = Color.White;
            barCode.ForeColor = Color.SteelBlue;
            barCode.RotationAngle = 0;
            barCode.CodeBinaryData = Encoding.Default.GetBytes(barCode.CodeText);
            barCode.Options.QRCode.CompactionMode = DevExpress.BarCodes.QRCodeCompactionMode.Byte;
            barCode.Options.QRCode.ErrorLevel = QRCodeErrorLevel.Q;
            barCode.Options.QRCode.ShowCodeText = false;
            barCode.DpiX = 72;
            barCode.DpiY = 72;
            barCode.Module = 2f;

            return barCode;
            /*
             주의  BarCodeImage 으로 비트맵 객체로 받아야함
            this.pictureEdit1.Image = tools.Barcode().BarCodeImage;
             */
        }
    }
}
