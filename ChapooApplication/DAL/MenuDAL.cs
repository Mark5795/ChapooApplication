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
    class MenuDAL : IMenuDAL
    {
        public List<Menu> GetItemByCategorie(int Id)
        {
            DBconnection conn = new DBconnection();
            SqlConnection sql = conn.Dbconnection();

            ItemDAL itemDAL = new ItemDAL();

            sql.Open();
            List<Menu> menus = new List<Menu>();

            StringBuilder sb = new StringBuilder();

            string query = "SELECT ItemId, MenuCategorie FROM Menu WHERE MenuCategorie = @Categorie";
            sb.Append(query);

            String sqlquery = sb.ToString();

            SqlParameter id = new SqlParameter("@Categorie", SqlDbType.Int, 3);

            SqlCommand command = new SqlCommand(sqlquery, sql);

            command.Parameters.Add(id).Value = Id;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int ItemId = reader.GetInt32(0);
                int MenuCategorie = reader.GetInt32(1);
                MenuItem item = itemDAL.ItemGetById(ItemId);
                Menu menu = new Menu(Id, item, MenuCategorie);
                menus.Add(menu);
            }

            reader.Close();
            sql.Close();
            return menus;
        }
    }

    public interface IMenuDAL
    {
        List<Menu> GetItemByCategorie(int Id);
    }
}
