using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public class Admin : User
    {
        internal List<Customer> Customers = new List<Customer>();
        public Admin(string id, string surname, string firstName, string middleName, string email, string username, string password, string phoneNumber, string address, DateTime birthDate, DateTime accountDateCreatead) : base(id, surname, firstName, middleName, email, username, password, phoneNumber, address, birthDate, accountDateCreatead)
        {


        }
    }
}
