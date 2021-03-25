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
        private SqlConnection conn = new SqlConnection("Server=.;database=IsTakip;trusted_connection=true");

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
