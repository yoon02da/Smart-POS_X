using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Smart_POS_X.POP_UP;
using Smart_POS_X.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
namespace Smart_POS_X
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBHelper dbHelper = new DBHelper();
            DBHelper.IP = "127.0.0.1";//"172.20.10.7,1433";  127.0.0.1 "172.20.10.7,1433";
            dbHelper.DB = "Master";
            dbHelper.ID = "sa";
            dbHelper.PWD = "tmakxmvhtm";
            dbHelper.DBStart(); 
            /*
             예제
            string a = "Y";
            var DT1 = dbHelper.Exec($"CODE_Select '카테고리','{a}'"); //테스트
            var DT2 = dbHelper.SQL("SELECT * FROM CODE"); //테스트
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

    }
} 
