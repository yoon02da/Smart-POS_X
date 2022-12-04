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
using static DevExpress.XtraEditors.RoundedSkinPanel;
using System.Security.Cryptography;
using System.Reflection;
using DevExpress.UnitConversion;
using static DevExpress.Xpo.DB.DataStoreLongrunnersWatch;

namespace Smart_POS_X.UI
{
    public partial class SalesManagedScreen : DevExpress.XtraEditors.XtraForm
    {
        DBHelper DB = new DBHelper();
        DataTable DT1 = new DataTable();
        DataTable DT2 = new DataTable();
        DataTable DT3 = new DataTable();
        DataTable DT4 = new DataTable();
        DataTable DT5 = new DataTable();
        DataTable DT6 = new DataTable();
        DataTable DT7 = new DataTable();


        public SalesManagedScreen()
        {
            InitializeComponent();

            ChartUp();
        }

        private void ChartUp()
        {
            Series series1 = new Series("Series1", ViewType.Bar);
            chart_Week.Series.Add(series1);

            DT1 = DB.SQL($"DashBoardScreen_S02");

            series1.DataSource = DT1;
            series1.ArgumentDataMember = "시간";
            series1.ValueDataMembers.AddRange(new string[] { "아메리카노판매" });
            series1.Label.TextPattern = "{A}:{V}";
            chart_Week.Series.Add(series1);
            chart_Week.Legend.Visible = false;
            chart_Week.AnimationStartMode = ChartAnimationMode.OnDataChanged;


            Series series2 = new Series("Series2", ViewType.Bar);
            chart_WeekMenu.Series.Add(series2);

            DT2 = DB.SQL($"With BASE_DATA AS(SELECT SellingDetail AS 품목, SellingCount as 개수, (SellingPrice * SellingCount) as 매출 " +
                $"FROM POSSellRecord WHERE CreateTime BETWEEN DATEADD(DD, -7, GETDATE()) AND GETDATE()) " +
                $"SELECT top 10 * FROM BASE_DATA AA ORDER BY AA.매출 desc");

            series2.DataSource = DT2;
            series2.ArgumentDataMember = "품목";
            series2.ValueDataMembers.AddRange(new string[] { "매출" });
            series2.Label.TextPattern = "{A}:{V}";
            chart_WeekMenu.Series.Add(series2);
            chart_WeekMenu.Legend.Visible = false;
            chart_WeekMenu.AnimationStartMode = ChartAnimationMode.OnDataChanged;


            Series series3 = new Series("Series3", ViewType.Bar);
            chart_TopDrink.Series.Add(series3);

            DT3 = DB.SQL($"With BASE_DATA AS (SELECT AA.SellingDetail AS 음료, AA.SellingCount as 개수, (AA.SellingPrice * AA.SellingCount) as 매출 " +
                $"FROM POSSellRecord AA " +
                $"INNER JOIN POSMenu BB ON AA.SellingDetail = BB.MenuName " +
                $"WHERE BB.CategoryName <> 'Dessert' AND BB.CategoryName <> 'ETC') " +
                $"SELECT top 10 * FROM BASE_DATA AA GROUP BY 음료, 매출, 개수 ORDER BY AA.개수 desc");

            series3.DataSource = DT3;
            series3.ArgumentDataMember = "음료";
            series3.ValueDataMembers.AddRange(new string[] { "개수" });
            series3.Label.TextPattern = "{A}:{V}";
            chart_TopDrink.Series.Add(series3);
            chart_TopDrink.Legend.Visible = false;
            chart_TopDrink.AnimationStartMode = ChartAnimationMode.OnDataChanged;


            Series series4 = new Series("Series4", ViewType.Bar);
            chart_Day.Series.Add(series4);

            DT4 = DB.SQL($"SELECT(SELECT SUM(AA.SellingPrice * AA.SellingCount) " +
                $"FROM POSSellRecord AA " +
                $"WHERE AA.CreateTime betWEEN DATEADD(DAY, -2, GETDATE()) AND DATEADD(DAY, -1, GETDATE())) AS 매출, '어제' as 날짜 " +
                $"UNION ALL " +
                $"SELECT(SELECT SUM(AA.SellingPrice * AA.SellingCount) " +
                $"FROM POSSellRecord AA " +
                $"WHERE  AA.CreateTime betWEEN DATEADD(DAY, -1, GETDATE()) AND GETDATE()) AS 매출, '오늘' as 날짜");

            series4.DataSource = DT4;
            series4.ArgumentDataMember = "날짜";
            series4.ValueDataMembers.AddRange(new string[] { "매출" });
            series4.Label.TextPattern = "{A}:{V}";
            chart_Day.Series.Add(series4);
            chart_Day.Legend.Visible = false;
            chart_Day.AnimationStartMode = ChartAnimationMode.OnDataChanged;


            Series series5 = new Series("Series5", ViewType.Bar);
            chart_TimeSale.Series.Add(series5);

            DT5 = DB.SQL($"DashBoardScreen_S01");

            series5.DataSource = DT5;
            series5.ArgumentDataMember = "시간";
            series5.ValueDataMembers.AddRange(new string[] { "시간당매출" });
            series5.Label.TextPattern = "{A}:{V}";
            chart_TimeSale.Series.Add(series5);
            chart_TimeSale.Legend.Visible = false;
            chart_TimeSale.AnimationStartMode = ChartAnimationMode.OnDataChanged;


            Series series6 = new Series("Series6", ViewType.Bar);
            chart_TopDessert.Series.Add(series6);

            DT6 = DB.SQL($"With BASE_DATA AS (SELECT AA.SellingDetail AS 디저트, AA.SellingCount as 개수, (AA.SellingPrice * AA.SellingCount) as 매출 " +
                $"FROM POSSellRecord AA " +
                $"INNER JOIN POSMenu BB ON AA.SellingDetail = BB.MenuName WHERE BB.CategoryName = 'Dessert') " +
                $"SELECT top 10 * FROM BASE_DATA AA GROUP BY 디저트, 매출, 개수 ORDER BY AA.개수 desc");

            series6.DataSource = DT6;
            series6.ArgumentDataMember = "디저트";
            series6.ValueDataMembers.AddRange(new string[] { "개수" });
            series6.Label.TextPattern = "{A}:{V}";
            chart_TopDessert.Series.Add(series6);
            chart_TopDessert.Legend.Visible = false;
            chart_TopDessert.AnimationStartMode = ChartAnimationMode.OnDataChanged;
        }

        private void chart_Week_Click(object sender, EventArgs e)
        {

        }
    }
}