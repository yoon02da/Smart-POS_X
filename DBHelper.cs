using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Data;
using DevExpress.Xpo.DB;
using DevExpress.XtraCharts.Native;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.Utils.Html.Internal;
using System.Runtime.Remoting.Messaging;

namespace Smart_POS_X
{
    class DBHelper
    {
        static public string IP { get; set; }
        public string DB { get; set; }
        public string ID { get; set; }
        public string PWD { get; set; }
        public string values { get; set; }
        public bool result { get; set; }
        public DataRow dataRow { get; set; }
        static public SqlConnection sqlConnection { get; set; }

        public void DBStart()
        {
            string con = $"Data Source={IP};Initial Catalog={DB};User ID={ID};Password={PWD}";
            SqlConnection DBConn = new SqlConnection(con);
            sqlConnection = DBConn;
        }
        public void DBSend()
        {
            sqlConnection.Close();
        }

        public DataTable Exec(string SQL) {
            SqlCommand CMD = new SqlCommand();
            CMD.Connection = sqlConnection;
            CMD.CommandText = $"EXEC {SQL}";

            SqlDataAdapter sd = new SqlDataAdapter(CMD);
            DataSet DS = new DataSet();

            try
            {
                sd.Fill(DS, "Table");
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"{ex}");
                result = false;
                return null;
            }

            if (DS.Tables.Count == 0)
            {
                result = false;
                return null;
            }
            result = true;

            DataTable DT = DS.Tables[0];

            if (DT.Rows.Count > 0 && DT.Columns.Count > 0)
            {
                values = DT.Rows[0][0].ToString();
                result = DT.Rows[0][0].ToString() == "1" ? true : false;
            }

            return DT;
        }

        public DataTable SQL(string SQL)
        {
            SqlCommand CMD = new SqlCommand();
            CMD.Connection = sqlConnection;
            CMD.CommandText = SQL;

            SqlDataAdapter sd = new SqlDataAdapter(CMD);
            DataSet DS = new DataSet();

            try
            {
                sd.Fill(DS, "Table");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                result = false;
                return null;
            }

            if (DS.Tables.Count == 0)
            {
                result = false;
                return null; 
            }
            result = true;

            DataTable DT = DS.Tables[0];

            if (DT.Rows.Count == 1)
            { 
                dataRow = DT.Rows[0]; 
            }

            return DT;
        }

        public bool TRAN(List<string> strings) 
        {
            SqlCommand CMD = new SqlCommand();
            CMD.Connection = sqlConnection;

            SqlTransaction tran = sqlConnection.BeginTransaction();
            CMD.Transaction = tran; // 현재사용할트랜잭션객체지정
            try
            {
                foreach (string sql in strings)
                {
                    CMD.CommandText = sql;// 쿼리지정
                    CMD.ExecuteNonQuery(); // 실행
                }
                tran.Commit(); // 트랜잭션commit
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                tran.Rollback(); // 에러발생시rollback
                return false;
            }
        }
        public bool DBCheckConnection()
        {
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("연결되었습니다.");
                sqlConnection.Close();
                return true;
            }
            else
            {
                MessageBox.Show("실패하였습니다.");
                sqlConnection.Close();
                return false;
            }
        }

    }
}
