using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Data;
using DevExpress.Xpo.DB;

namespace Smart_POS_X
{

    class DBHelper
    {
        public string IP { get; set; }
        public string DB { get; set; }
        public string ID { get; set; }
        public string PWD { get; set; }
        static public SqlConnection sqlConnection { get; set; }

        public void DBStart()
        {
            string con = $"Data Source={IP};Initial Catalog={DB};User ID={ID};Password={PWD}";
            SqlConnection DBConn = new SqlConnection(con);

            sqlConnection = DBConn;
        }

        public DataTable Exec(string SQL) {
            sqlConnection.Open();

            SqlCommand CMD = new SqlCommand();
            CMD.Connection = sqlConnection;
            CMD.CommandText = $"EXEC {SQL}";

            SqlDataAdapter sd = new SqlDataAdapter(CMD);
            DataSet DS = new DataSet();
            sd.Fill(DS, "Table");

            DataTable DT = DS.Tables[0];

            sqlConnection.Close();
            return DT;
        }

        public DataTable SQL(string SQL)
        {
            sqlConnection.Open();

            SqlCommand CMD = new SqlCommand();
            CMD.Connection = sqlConnection;
            CMD.CommandText = SQL;

            SqlDataAdapter sd = new SqlDataAdapter(CMD);
            DataSet DS = new DataSet();
            sd.Fill(DS, "Table");

            DataTable DT = DS.Tables[0];

            sqlConnection.Close();
            return DT;
        }
    }
}
