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
    class OverviewDAL : IOverviewDAL
    {
        public List<OrderItem> GetOrderItemsForOverview(Function function)
        {
            DBconnection conn = new DBconnection();
            SqlConnection sql = conn.Dbconnection();

            sql.Open();
            IItemDAL itemDAL = new ItemDAL();
            List<OrderItem> Orderitems = new List<OrderItem>();

            StringBuilder sb = new StringBuilder();

            string query;

            if (function == Function.Barkeeper)
            {
                query = "SELECT Order.OrderId, MenuItem.Name, OrderItem.Count, Order.TableId, OrderItem.Comment FROM OrderItem INNER JOIN Order on OrderItem.Order = Order.OrderId INNER JOIN MenuItem on OrderItem.MenuItemId = MenuItem.ItemId WHERE OrderItem.MenuItem > 21 AND OrderItem.OrderStatus != 3 ORDER BY Order.TableId ";
            }
            else
            {
                query = "SELECT Order.OrderId, MenuItem.Name, OrderItem.Count, Order.TableId, OrderItem.Comment FROM OrderItem INNER JOIN Order on OrderItem.Order = Order.OrderId INNER JOIN MenuItem on OrderItem.MenuItemId = MenuItem.ItemId WHERE OrderItem.MenuItem < 21 AND OrderItem.OrderStatus != 3 ORDER BY Order.TableId ";
            }

            sb.Append(query);
            String sqlquery = sb.ToString();

            SqlCommand command = new SqlCommand(query, sql);
            command.Prepare();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int OrderId = reader.GetInt32(0);
                Order order = new Order(OrderId);
                string MenuItemName = reader.GetString(1);
                MenuItem MenuItem = itemDAL.ItemGetByName(MenuItemName);
                int Count = reader.GetInt32(2);
                int TableId = reader.GetInt32(3);
                Table table = new Table(TableId);
                string Comment = reader.GetString(4);

                OrderItem orderitem = new OrderItem(order, MenuItem, Count, table, Comment);
                Orderitems.Add(orderitem);

            }

            sql.Close();
            return Orderitems;
        }
    }

    public interface IOverviewDAL
    {
        List<OrderItem> GetOrderItemsForOverview(Function function);
    }
}
