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
    class EmployeeDAL : IEmployeeDAL
    {
        public Employee CheckEmployeeCredentials(int id, string password)
        {
            DBconnection conn = new DBconnection();
            SqlConnection sql = conn.Dbconnection();
            sql.Open();
            //Employee employee = new Employee();
            StringBuilder sb = new StringBuilder();

            sb.Append("Select Password");
            sb.Append("FROM Employee WHERE Id = @Id");

            String query = sb.ToString();
            SqlParameter id = new SqlParameter("@Id", SqlDbType.Int, 3);
            SqlCommand command = new SqlCommand(query, sql);
            command.Parameters.Add(id).Value = Id;
            SqlDataReader reader = command.ExecuteReader();
            command.Prepare();

            while (reader.Read())
            {
                int Id = reader.GetInt32(1);
                string Password = reader.GetString(2);
                string FirstName = reader.GetString(3);
                string LastName = reader.GetString(4);
                DateTime BirthDay = reader.GetDateTime(5);
                int PhoneNumber = reader.GetInt32(6);
                string Email = reader.GetString(7);
                string InternationBankAccountNumber = reader.GetString(8);
                Function function = (Function)reader.GetInt32(9);

                Employee employee = new Employee(Id, Password, FirstName, LastName, BirthDay, PhoneNumber, Email, InternationBankAccountNumber, function);
            }

            reader.Close();
            sql.Close();

            return employee;
        }
    }

    public interface IEmployeeDAL
    {

    }
}
