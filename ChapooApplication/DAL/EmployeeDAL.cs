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
        public Employee GetEmployee(int EmployeeId)
        {
            Employee employee = new Employee();

            DBconnection conn = new DBconnection();
            SqlConnection sql = conn.Dbconnection();
            sql.Open();

            string query = "SELECT * FROM Employee WHERE EmployeeId = @EmployeeId";

            StringBuilder sb = new StringBuilder();            
                        
            sb.Append(query);
            String sqlquery = sb.ToString();

            SqlParameter employeeId = new SqlParameter("@EmployeeId", SqlDbType.Int, 3);
            SqlCommand command = new SqlCommand(query, sql);
            command.Parameters.Add(employeeId).Value = EmployeeId;
            SqlDataReader reader = command.ExecuteReader();
            //command.Prepare();

            while (reader.Read())
            {
                string Password = reader.GetString(1);
                string FirstName = reader.GetString(2);
                string LastName = reader.GetString(3);
                DateTime BirthDay = reader.GetDateTime(4);
                int PhoneNumber = reader.GetInt32(5);
                string Email = reader.GetString(6);
                string InternationBankAccountNumber = reader.GetString(7);
                Function function = (Function)reader.GetInt32(8);

                employee = new Employee(EmployeeId, Password, FirstName, LastName, BirthDay, PhoneNumber, Email, InternationBankAccountNumber, function);
            }

            reader.Close();
            sql.Close();

            return employee;
        }

        public bool CheckEmployeeCredentials(Employee employee)
        {
            if (GetEmployee(employee.EmployeeId).EmployeeId == employee.EmployeeId)
            {
                if (GetEmployee(employee.EmployeeId).Password == employee.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public interface IEmployeeDAL
    {
        Employee GetEmployee(int EmployeeId);
        bool CheckEmployeeCredentials(Employee employee);
    }
}
