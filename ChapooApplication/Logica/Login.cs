using ChapooApplication.DAL;
using ChapooApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.Logica
{
    class Login
    {
        public Function funtion(Employee employee)
        {
            EmployeeDAL Werknemer_Object = new EmployeeDAL();
            Function funtion = Werknemer_Object.WerknemerGetFunctie(employee);

            return funtion;
        }
    }
}
