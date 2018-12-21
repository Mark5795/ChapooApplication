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

            string query = "INSERT INTO OrderItem (MenuItemId, Aantal, Bestelling, Status, Commentaar, Afgeleverd) Values (@MenuItem, @aantal, @bestelling, @Status, @Commentaar, @afgeleverd);";

            sb.Append(query);

            String sqlquery = sb.ToString();

            SqlParameter MenuItem = new SqlParameter("@MenuItem", SqlDbType.Int, 3);
            SqlParameter Aantal = new SqlParameter("@Aantal", SqlDbType.Int, 5);
            SqlParameter Bestelling = new SqlParameter("@bestelling", SqlDbType.Int);
            SqlParameter Status = new SqlParameter("@Status", SqlDbType.Bit, 1);
            SqlParameter Commentaar = new SqlParameter("@Commentaar", SqlDbType.NVarChar, 500);
            SqlParameter afgeleverd = new SqlParameter("@afgeleverd", SqlDbType.Bit);

            SqlCommand command = new SqlCommand(sqlquery, sql);

            command.Parameters.Add(MenuItem).Value = orderItem.Item.ItemId;
            command.Parameters.Add(Aantal).Value = orderItem.Count;
            command.Parameters.Add(Bestelling).Value = orderItem.Bestelling.BestellingId;
            command.Parameters.Add(Status).Value = orderItem.OrderStatus;
            command.Parameters.Add(Commentaar).Value = orderItem.Commentaar;
            command.Parameters.Add(afgeleverd).Value = orderItem.Afgeleverd;

            command.ExecuteNonQuery();
            sql.Close();
        }
    }

    public interface IOrderItemDAL
    {

    }
}
