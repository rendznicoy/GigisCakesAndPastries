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
        public string Surname { get; private set; }
        public string Firstname { get; private set; }
        public string MiddleName { get; private set; }
        public string Email { get; private set; }
        public string Username { get; private set; }
        private string Password;
        public string PhoneNumber { get; private set; }
        public string Address { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime AccountDateCreatead { get; private set; }

        public User (string id, string surname, string firstName, string middleName, string email, string username, string password, string phoneNumber, string address, DateTime birthDate, DateTime accountDateCreatead)
        {
            this.ID = id;
            this.Surname = surname;
            this.Firstname = firstName;
            this.MiddleName = middleName;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.BirthDate = birthDate;
            this.AccountDateCreatead = accountDateCreatead;
        }

        public bool CanLogin(string username, string password)
        {
            return username.Equals(this.Username) && password.Equals(this.Password);
        }
    }
}
