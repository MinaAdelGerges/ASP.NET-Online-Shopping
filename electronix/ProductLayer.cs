using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace electronix
{
    public class ProductLayer
    {


        //insert
        public static int InsertProduct(int category_id,string name,int price,string description,string image)
        {
            
                SqlCommand cmd = new SqlCommand("insert into Product(CategoryId,Name,Price,Description,Image) values(@category_id,@name,@price,@description,@image)");
                cmd.Parameters.AddWithValue("category_id", category_id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("price", price);
                cmd.Parameters.AddWithValue("description", description);
                cmd.Parameters.AddWithValue("image", image);
                return DBLayers.DML(cmd);
            
           
        }


        //delete

        public static int DeleteProduct(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Product where Id=@id");
            cmd.Parameters.AddWithValue("id", id);
            return DBLayers.DML(cmd);
        }


        //update
        public static int UpdateProduct(int id, int category_id, string name, int price, string description, string image)
        {

            SqlCommand cmd = new SqlCommand("update Product set Id=@id ,Category_Id=@category_id,Name=@name,Price=@price,Description=@description,Image=@image where Id=@id)");
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("category_id", category_id);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("price", price);
            cmd.Parameters.AddWithValue("description", description);
            cmd.Parameters.AddWithValue("image", image);
            return DBLayers.DML(cmd);


        }
        public static DataTable GetProduct(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from Product where Id=@id");
            cmd.Parameters.AddWithValue("id", id);
    
            return DBLayers.select(cmd);
        }
        public static DataTable GetAllProducts()
        {
           
            SqlCommand cmd = new SqlCommand("select * from Product");
            return DBLayers.select(cmd);

        }
        public static DataTable GetProductByCategory(int category_id)
        {

            SqlCommand cmd = new SqlCommand("select * from Product where CategoryId="+category_id+")");
            return DBLayers.select(cmd);

        }
 
    }
}