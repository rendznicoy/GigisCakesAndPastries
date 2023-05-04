using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public abstract class User
    {
        private string ID { get; set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        private string Password;
        public string PhoneNumber { get; private set; }
        public string Address { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime AccountDateCreatead { get; private set; }

        public User (string id, string name, string email, string password, string phoneNumber, string address, DateTime birthDate, DateTime accountDateCreatead)
        {
            this.ID = id;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.BirthDate = birthDate;
            this.AccountDateCreatead = accountDateCreatead;
        }
    }
}
