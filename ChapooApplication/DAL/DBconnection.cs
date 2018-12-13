using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ChapooApplication.DAL
{
    class DBconnection
    {
        public SqlConnection Dbconnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionStringSQL"].ConnectionString;
            SqlConnection sqls = new SqlConnection(connString);

            return sqls;
        }
    }
}
