using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public abstract class User
    {
        public string ID { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        
        [JsonRequired]
        private string Password;
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string BirthMonth { get; set; }
        public string BirthDate { get; set; }
        public string BirthYear { get; set; }
        public DateTime AccountDateCreatead { get; set; }

        public User (string id, string surname, string firstName, string middleName, string email, string username, string password, string phoneNumber, string address, string birthMonth, string birthDate, string birthYear, DateTime accountDateCreatead)
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
            this.BirthMonth = birthMonth;
            this.BirthDate = birthDate;
            this.BirthYear = birthYear;
            this.AccountDateCreatead = accountDateCreatead;
        }

        public bool CanLogin(string username, string password)
        {
            return username.Equals(this.Username) && password.Equals(this.Password);
        }
    }
}
