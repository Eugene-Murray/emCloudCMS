using System;
using System.Linq;
using Dapper;
using EM.Cloud.Data.Entities;
using Microsoft.Data.SqlClient;

namespace em.cloud.data.dapper
{
    public static class DapperTest
    {
        private static string sqlBlogs = "SELECT TOP 5 * FROM Blogs;";
        //private static string sqlOrderDetail = "SELECT * FROM OrderDetails WHERE OrderDetailID = @OrderDetailID;";
        //private static string sqlCustomerInsert = "INSERT INTO Customers (CustomerName) Values (@CustomerName);";

        public static void GetBlogData()
        {
            using var connection = new SqlConnection("Server=DESKTOP-8MD6M17\\SQLEXPRESS;Database=emCloudCMS;Integrated Security=true;");
            var orderDetails = connection.Query<Blog>(sqlBlogs).ToList();

            Console.WriteLine(orderDetails.Count);
            

            //FiddleHelper.WriteTable(orderDetails);
            //FiddleHelper.WriteTable(new List<OrderDetail>() { orderDetail });
        }
    }
}
