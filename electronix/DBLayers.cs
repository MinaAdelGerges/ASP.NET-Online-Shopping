using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace electronix
{
    public static class DBLayers
    {
        public static DataTable select(SqlCommand query)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["electronix"].ConnectionString);
            SqlCommand cmd = query;
            cmd.Connection = con;

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adpt.Fill(dt);

            return dt;
        }
        public static int DML(SqlCommand command)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["electronix"].ConnectionString);
            SqlCommand cmd = command;
            cmd.Connection = con;
            con.Open();

            int roweffect = cmd.ExecuteNonQuery();


            con.Close();

            return roweffect;
        }


    }
}