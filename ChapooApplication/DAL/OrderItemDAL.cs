using ChapooApplication.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.DAL
{
    public class OrderItemDAL : IOrderItemDAL
    {
        public void AddOrderItem(OrderItem orderItem)
        {
            DBconnection conn = new DBconnection();
            SqlConnection sql = conn.Dbconnection();

            sql.Open();

            StringBuilder sb = new StringBuilder();

            string query = "INSERT INTO OrderItem (OrderId, MenuItemId, TableId, Count, OrderStatus, Comment) Values (@OrderId, @MenuItemId, @TableId, @Count, @OrderStatus, @Comment);";

            sb.Append(query);

            String sqlquery = sb.ToString();

            SqlParameter OrderId = new SqlParameter("@OrderId", SqlDbType.Int, 3);
            SqlParameter MenuItemId = new SqlParameter("@MenuItemId", SqlDbType.Int, 5);
            SqlParameter TableId = new SqlParameter("@TableId", SqlDbType.Int);
            SqlParameter Count = new SqlParameter("@Count", SqlDbType.Int, 1);
            SqlParameter OrderStatus = new SqlParameter("@OrderStatus", SqlDbType.Int);
            SqlParameter Comment = new SqlParameter("@Comment", SqlDbType.NVarChar, 500);

            SqlCommand command = new SqlCommand(sqlquery, sql);

            command.Parameters.Add(OrderId).Value = orderItem.Order.OrderId;
            command.Parameters.Add(MenuItemId).Value = orderItem.MenuItem.ItemId;
            command.Parameters.Add(TableId).Value = orderItem.Table.TableId;
            command.Parameters.Add(Count).Value = orderItem.Count;
            command.Parameters.Add(OrderStatus).Value = orderItem.OrderStatus;
            command.Parameters.Add(Comment).Value = orderItem.Comment;

            command.ExecuteNonQuery();
            sql.Close();
        }
    }

    public interface IOrderItemDAL
    {
        void AddOrderItem(OrderItem orderItem);
    }
}
