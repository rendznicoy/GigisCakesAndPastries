using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public class Admin : User
    {
        public Admin(string id, string name, string email, string password, string phoneNumber, string address, DateTime birthDate, DateTime accountDateCreatead) : base (id, name, email, password, phoneNumber, address, birthDate, accountDateCreatead)
        {
            
        }
    }
}
