using ChapooApplication.Logica;
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
            String sqlquery = query.ToString();

            SqlCommand command = new SqlCommand(sqlquery, sql);
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

        public void ChangeTableStatus(int status, Table table)
        {
            TableService tableService = new TableService();
            int tableStatus = status;

            DBconnection conn = new DBconnection();
            SqlConnection sql = conn.Dbconnection();

            sql.Open();

            string query = "UPDATE RestaurantTable Set TableStatus = @TableStatus WHERE TableId = @TableId";

            StringBuilder sb = new StringBuilder();
            sb.Append(query);
            String sqlquery = sb.ToString();

            SqlParameter TableId = new SqlParameter("@TableId", SqlDbType.Int, 3);
            SqlParameter TableStatus = new SqlParameter("@tableStatus", SqlDbType.Int, 3);

            SqlCommand command = new SqlCommand(query, sql);

            command.Parameters.Add(TableId).Value = table.TableId;
            command.Parameters.Add(TableStatus).Value = tableStatus;

            command.ExecuteNonQuery();
            sql.Close();
        }

        public int GetTableId(Table table)
        {
            int TableId = table.TableId;
            int tableId = 0;

            DBconnection conn = new DBconnection();
            SqlConnection sql = conn.Dbconnection();

            sql.Open();

            string query = "SELECT TableId FROM RestaurantTable WHERE TableId = @TableId";

            StringBuilder sb = new StringBuilder();

            sb.Append(query);
            String sqlquery = sb.ToString();

            SqlParameter TableIdDB = new SqlParameter("@TableId", SqlDbType.Int, 3);
            SqlCommand command = new SqlCommand(query, sql);
            command.Prepare();
            command.Parameters.Add(TableIdDB).Value = TableId;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tableId = reader.GetInt32(0);
            }

            reader.Close();
            sql.Close();
            return tableId;
        }
    }


    public interface ITableDAL
    {
        List<Table> GetAllTables();
        void ChangeTableStatus(int status, Table table);
        int GetTableId(Table table);
    }
}
