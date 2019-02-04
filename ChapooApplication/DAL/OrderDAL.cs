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
    public class OrderDAL : IOrderDAL
    {
        public int AddOrder(Order order)
        {
            DBconnection conn = new DBconnection();
            SqlConnection sql = conn.Dbconnection();

            sql.Open();


            StringBuilder sb = new StringBuilder();

            string query = "INSERT INTO OrderMenu (TableId, OrderTime, Date, Paid, PaymentMethod) VALUES (@TableId, @OrderTime, @Date, @Paid, @PaymentMethod); ";

            sb.Append(query);

            String sqlquery = sb.ToString();

            SqlParameter TableId = new SqlParameter("@TableId", SqlDbType.Int);
            SqlParameter OrderTime = new SqlParameter("@OrderTime", SqlDbType.Time, 5);
            SqlParameter Date = new SqlParameter("@Date", SqlDbType.Date, 3);
            SqlParameter Paid = new SqlParameter("@Paid", SqlDbType.Bit);
            SqlParameter PaymentMethod = new SqlParameter("@PaymentMethod", SqlDbType.Int);


            SqlCommand command = new SqlCommand(sqlquery, sql);

            DateTime now = DateTime.Now;
            command.Parameters.Add(TableId).Value = order.Table.TableId;      
            command.Parameters.Add(OrderTime).Value = now.Hour + ":" + now.Minute + ":" + now.Second;
            command.Parameters.Add(Date).Value = now.Date;
            command.Parameters.Add(Paid).Value = order.Paid;
            command.Parameters.Add(PaymentMethod).Value = order.PaymentMethod;

            command.ExecuteNonQuery();


            query = "SELECT MAX(OrderMenuId) FROM OrderMenu";
            //sb.Append(query);
            //sqlquery = sb.ToString();
            //command = new SqlCommand(sqlquery, sql);
            command = new SqlCommand(query, sql);

            return (int)command.ExecuteScalar();
        }
    }

    public interface IOrderDAL
    {
        int AddOrder(Order order);
    }
}
