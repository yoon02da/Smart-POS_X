﻿using System;
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

namespace Smart_POS_X
{

    class DBHelper
    {
        static public string IP { get; set; }
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
