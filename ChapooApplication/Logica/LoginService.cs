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
        private EmployeeDAL employeeDAL = new EmployeeDAL();

        public bool CheckLogin(Employee employee)
        {
            if (employeeDAL.CheckEmployeeCredentials(employee))
            {
                return true;
            }
            return false;
        }

        //public Function funtion(Employee employee)
        //{
        //    EmployeeDAL employee = new EmployeeDAL();
        //    //Function funtion = Werknemer_Object.EmployeeGetFunctie(employee);

        //    return funtion;
        //}
    }
}
