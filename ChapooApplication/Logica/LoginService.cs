using ChapooApplication.DAL;
using ChapooApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.Logica
{
    class LoginService
    {
        private IEmployeeDAL employeeDAL = new EmployeeDAL();

        public bool CheckLogin(Employee employee)
        {
            if (employeeDAL.CheckEmployeeCredentials(employee))
            {
                return true;
            }
            return false;
        }
        
        public Function funtion(Employee employee)
        {
            Function function = employeeDAL.GetEmployee(employee.Id).function;
            return function;
        }
    }
}
