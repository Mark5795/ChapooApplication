using ChapooApplication.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.DAL
{
    public class TableDAL : ITableDAL
    {
        public List<Table> GetAllTables()
        {
            List<Table> TableList = new List<Table>();
            DBconnection conn = new DBconnection();
            SqlConnection sql = conn.Dbconnection();

            sql.Open();

            string query = "SELECT * FROM RestaurantTable";
            StringBuilder sb = new StringBuilder();

            sb.Append(query);
            String sqlquery = sb.ToString();

            SqlCommand command = new SqlCommand(query, sql);
            command.Prepare();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int TableId = reader.GetInt32(0);
                int TableStatus = reader.GetInt32(1);
                Table table = new Table(TableId, TableStatus);
                TableList.Add(table);
            }

            reader.Close();
            sql.Close();

            return TableList;
        }

        public void ChangeTableStatus()
        {
            DBconnection conn = new DBconnection();
            SqlConnection sql = conn.Dbconnection();

            sql.Open();

            string query = "UPDATE RestaurantTable Set TableStatus =  FROM RestaurantTable";
            StringBuilder sb = new StringBuilder();

            sb.Append(query);
            String sqlquery = sb.ToString();

            SqlCommand command = new SqlCommand(query, sql);
            command.Prepare();

            SqlDataReader reader = command.ExecuteReader();

        }
    }


    public interface ITableDAL
    {
        List<Table> GetAllTables();
    }
}
