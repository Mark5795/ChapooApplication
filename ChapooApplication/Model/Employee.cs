using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooApplication.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string InternationalBankAccountNumber { get; set; }
        public Function function { get; set; }

        public Employee(int Id, string Password, string FirstName, string LastName, DateTime BirthDay, int PhoneNumber, string Email, string InternationalBankAccountNumber, Function function)
        {
            this.Id = Id;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDay = BirthDay;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.InternationalBankAccountNumber = InternationalBankAccountNumber;
            this.function = function;
        }
    }
}
