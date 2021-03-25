using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace IsTakip.DAL
{
    public class Connector
    {
        private SqlConnection conn = new SqlConnection("Server=94.73.146.7;database=DB140303164750;User ID=USR140303164750;pwd=Eserkucuker1;Integrated Security=false;");

        protected SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            return conn;
        }

        protected void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
