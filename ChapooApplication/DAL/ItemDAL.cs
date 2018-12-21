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
    class ItemDAL : IItemDAL
    {
        public MenuItem ItemGetByName(string Name)
        {
            DBconnection conn = new DBconnection();
            SqlConnection sql = conn.Dbconnection();

            MenuItem menuItem = null;
            sql.Open();

            StringBuilder sb = new StringBuilder();

            string query = "SELECT ItemId, Name, Price, Count FROM MenuItem WHERE Name = @Name";

            sb.Append(query);

            String sqlquery = query.ToString();

            SqlParameter name = new SqlParameter("@Name", SqlDbType.NVarChar, 100);

            SqlCommand command = new SqlCommand(sqlquery, sql);
            command.Parameters.Add(name).Value = Name;
            command.Prepare();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int Id = reader.GetInt32(0);
                string NameDb = Name;
                float Price = (float)reader.GetDouble(2);
                int Count = reader.GetInt32(3);

                menuItem = new MenuItem(Id, NameDb, Price, Count);
            }

            reader.Close();
            sql.Close();

            return menuItem;
        }

        public MenuItem ItemGetById(int Id)
        {
            DBconnection conn = new DBconnection();
            SqlConnection sql = conn.Dbconnection();
            MenuItem menuitem = null;

            sql.Open();

            StringBuilder sb = new StringBuilder();

            string query = "SELECT ItemId, Name, Price, Count FROM MenuItem WHERE ItemId = @ItemId";
            sb.Append(query);

            String sqlquery = sb.ToString();

            SqlParameter ItemID = new SqlParameter("@ItemID", SqlDbType.Int, 3);

            SqlCommand command = new SqlCommand(sqlquery, sql);
            command.Parameters.Add(ItemID).Value = Id;
            command.Prepare();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string name = reader.GetString(1);
                float price = (float)reader.GetDouble(2);
                int count = reader.GetInt32(3);

                menuitem = new MenuItem(Id, name, price, count);
            }

            reader.Close();
            sql.Close();

            return menuitem;
        }
    }

    public interface IItemDAL
    {
        MenuItem ItemGetByName(string Name);
        MenuItem ItemGetById(int Id);
    }
}
