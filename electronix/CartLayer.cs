using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace electronix
{
    public class CartLayer
    {

        //insert
        public static int InsertCart(int user_id, int product_id, int amount, DateTime date_purchased)
        {

            SqlCommand cmd = new SqlCommand("insert into Cart (UserId,ProductId,Amount,DatePurchased)values(@user_id,@product_id,@amount,@date_purchased)");
         
            cmd.Parameters.AddWithValue("user_id", user_id);
            cmd.Parameters.AddWithValue("product_id", product_id);
            cmd.Parameters.AddWithValue("amount", amount);
            cmd.Parameters.AddWithValue("date_purchased", date_purchased);
            return DBLayers.DML(cmd);


        }


        //delete

        public static int DeleteCart(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Cart where CID=@id)");
            cmd.Parameters.AddWithValue("id", id);
            return DBLayers.DML(cmd);
        }


        //update
        public static int UpdateCart(int id, int user_id, int product_id, int amount, DateTime date_purchased)
        {

            SqlCommand cmd = new SqlCommand("Update Cart set UserId=@user_id,ProductId=@product_id,Amount=@amount,DatePurchased=@date_purchased)");
            
            cmd.Parameters.AddWithValue("user_id", user_id);
            cmd.Parameters.AddWithValue("product_id", product_id);
            cmd.Parameters.AddWithValue("amount", amount);
            cmd.Parameters.AddWithValue("date_purchased", date_purchased);
            return DBLayers.DML(cmd);



        }
    }
}