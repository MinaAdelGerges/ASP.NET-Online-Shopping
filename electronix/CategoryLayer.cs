using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace electronix
{
    public class CategoryLayer
    {
        //insert
        public static int InsertCategory( string name)
        {

            SqlCommand cmd = new SqlCommand("insert into Category values(@name)");
           
            cmd.Parameters.AddWithValue("name", name);
 
            return DBLayers.DML(cmd);


        }


        //delete

        public static int DeleteCategory(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Category where Id=@id");
            cmd.Parameters.AddWithValue("id", id);
            return DBLayers.DML(cmd);
        }


        //update
        public static int UpdateCategory(int id,string name)
        {

            SqlCommand cmd = new SqlCommand("update Category set Id=@id,Name=@name)");
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", name);

            return DBLayers.DML(cmd);


        }
    }
}