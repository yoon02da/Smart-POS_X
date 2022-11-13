using DevExpress.XtraCharts.Native;
using DevExpress.XtraCharts;
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
    public partial class SalesManagedScreen : DevExpress.XtraEditors.XtraForm
    {
        DBHelper DB = new DBHelper();
        DataTable DT1 = new DataTable();

        public SalesManagedScreen()
        {
            InitializeComponent();
        }

        private void ChartUp()
        {
            Series series3 = new Series("Series1", ViewType.Bar);
            chart_WeekMenu.Series.Add(series3);

            DT1 = DB.SQL($"SELECT TOP(10) RANK() OVER (ORDER BY AA.SellingDetail DESC) AS 순위 " +
                $"FROM POSSellRecord AA AS 메뉴" +
                $"ORDER BY AA.CreateTime");
            series3.DataSource = DT1;

            series3.ArgumentScaleType = ScaleType.Numerical;
            series3.ArgumentDataMember = "Argument";
            series3.ValueScaleType = ScaleType.Numerical;
            series3.ValueDataMembers.AddRange(new string[] { "Value" });

            ((SideBySideBarSeriesView)series3.View).ColorEach = true;
            ((XYDiagram)chart_WeekMenu.Diagram).AxisX.Visibility = DevExpress.Utils.DefaultBoolean.False;
            chart_WeekMenu.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            chart_WeekMenu.Dock = DockStyle.Fill;
            this.Controls.Add(chart_WeekMenu);
        }
    }
}