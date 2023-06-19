using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GigisCakesAndPastries
{
    public class Admin : User
    {
        internal List<Customer> Customers = new List<Customer>();
        internal List<Products> Products = new List<Products>();
        internal List<Orders> Order = new List<Orders>();
        public Admin(string id, string surname, string firstName, string middleName, string email, string username, string password, string phoneNumber, string address, string birthMonth, string birthDate, string birthYear, DateTime accountDateCreatead) : base(id, surname, firstName, middleName, email, username, password, phoneNumber, address, birthMonth, birthDate, birthYear, accountDateCreatead)
        {


        }
    }
}
