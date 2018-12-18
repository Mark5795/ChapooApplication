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
        //public List<Employee> GetEmployee(int Id)
        //{
        //    List<Employee> employees = new List<Employee>();

        //    DBconnection conn = new DBconnection();
        //    SqlConnection sql = conn.Dbconnection();
        //    sql.Open();            
        //    StringBuilder sb = new StringBuilder();

        //    sb.Append("Select Password");
        //    sb.Append("FROM Employee WHERE Id = @Id");

        //    String query = sb.ToString();
        //    SqlParameter id = new SqlParameter("@Id", SqlDbType.Int, 3);
        //    SqlCommand command = new SqlCommand(query, sql);
        //    command.Parameters.Add(id).Value = Id;
        //    SqlDataReader reader = command.ExecuteReader();
        //    command.Prepare();

        //    while (reader.Read())
        //    {
        //        //int Id = reader.GetInt32(1);
        //        string Password = reader.GetString(1);
        //        string FirstName = reader.GetString(2);
        //        string LastName = reader.GetString(3);
        //        DateTime BirthDay = reader.GetDateTime(4);
        //        int PhoneNumber = reader.GetInt32(5);
        //        string Email = reader.GetString(6);
        //        string InternationBankAccountNumber = reader.GetString(7);
        //        Function function = (Function)reader.GetInt32(8);

        //        Employee employee = new Employee(Id, Password, FirstName, LastName, BirthDay, PhoneNumber, Email, InternationBankAccountNumber, function);
        //        employees.Add(employee);
        //    }

        //    reader.Close();
        //    sql.Close();

        //    return employees;
        //}

        public Employee GetEmployee(int Id)
        {
            Employee employee = new Employee();

            DBconnection conn = new DBconnection();
            SqlConnection sql = conn.Dbconnection();
            sql.Open();
            StringBuilder sb = new StringBuilder();

            sb.Append("Select *");
            sb.Append("FROM Employee WHERE Id = @Id");

            String query = sb.ToString();
            SqlParameter id = new SqlParameter("@Id", SqlDbType.Int, 3);
            SqlCommand command = new SqlCommand(query, sql);
            command.Parameters.Add(id).Value = Id;
            SqlDataReader reader = command.ExecuteReader();
            //command.Prepare();

            while (reader.Read())
            {
                //int Id = reader.GetInt32(1);
                string Password = reader.GetString(1);
                string FirstName = reader.GetString(2);
                string LastName = reader.GetString(3);
                DateTime BirthDay = reader.GetDateTime(4);
                int PhoneNumber = reader.GetInt32(5);
                string Email = reader.GetString(6);
                string InternationBankAccountNumber = reader.GetString(7);
                Function function = (Function)reader.GetInt32(8);

                employee = new Employee(Id, Password, FirstName, LastName, BirthDay, PhoneNumber, Email, InternationBankAccountNumber, function);
            }

            reader.Close();
            sql.Close();

            return employee;
        }

        //public bool CheckEmployeeCredentials(int Id, string Password)
        //{
        //    if (GetEmployee(Id).Id == Id)
        //    {
        //        if (GetEmployee(Id).Password == Password)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public bool CheckEmployeeCredentials(Employee employee)
        {
            if (GetEmployee(employee.Id).Id == employee.Id)
            {
                if (GetEmployee(employee.Id).Password == employee.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public interface IEmployeeDAL
    {
        //bool CheckEmployeeCredentials(int id, string password);
        bool CheckEmployeeCredentials(Employee employee);
        //List<Employee> GetEmployee(int Id);
        Employee GetEmployee(int Id);
    }
}
