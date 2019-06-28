using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace electronix
{
    public class UsersLayer
    {
        //insert
        public static int InsertUser(string name, int age, string password, string email, string gender, string image)
        {

            SqlCommand cmd = new SqlCommand("insert into Users(Name,Age,Password,Email,Gender,Image) values(@name,@age,@password,@email,@gender,@image)");
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("age", age);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("gender", gender);
            cmd.Parameters.AddWithValue("image", image);
            return DBLayers.DML(cmd);


        }


        //delete

        public static int DeleteUser(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Users where Id=@id");
            cmd.Parameters.AddWithValue("id", id);
            return DBLayers.DML(cmd);
        }


        //update
        public static int UpdateUser(int id, string name, int age, string password, string email, string gender, string image)
        {

            SqlCommand cmd = new SqlCommand("update Users set Name=@name ,Age=@age,Password=@password,Email=@email,Gender=@gender,Image=@image where Id=@id)");
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("age", age);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("image", image);
            return DBLayers.DML(cmd);
        }

        public static int changePassword(int id,string newPassword)
        {
            SqlCommand cmd = new SqlCommand("update Users set Password=@password where Id=@id");
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("password", newPassword);
           
            return DBLayers.DML(cmd);
        }
        //select
        public static DataTable GetUserId(string name,string password)
        {
            SqlCommand cmd = new SqlCommand("select Id from Users where Name=@name and Password=@password");
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("password", password);

            return DBLayers.select(cmd);
        }
        public static DataTable GetUser(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from Users where Id=@id");
            cmd.Parameters.AddWithValue("id", id);

            return DBLayers.select(cmd);
        }
        public static DataTable GetAllUsers()
        {
            SqlCommand cmd = new SqlCommand("select * from Users");
            return DBLayers.select(cmd);

        }
        
    }
}