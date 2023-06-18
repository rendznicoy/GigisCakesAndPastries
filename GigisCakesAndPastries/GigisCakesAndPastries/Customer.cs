using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public class Customer : User
    {
        public int LoyaltyPoints { get; private set; }
        internal List<Products> FavouriteProducts = new List<Products>();
        public Customer(string id, string surname, string firstName, string middleName, string email, string username, string password, string phoneNumber, string address, string birthMonth, string birthDate, string birthYear, DateTime accountDateCreatead) : base(id, surname, firstName, middleName, email, username, password, phoneNumber, address, birthMonth, birthDate, birthYear, accountDateCreatead)
        {
            this.LoyaltyPoints = 0;
            FavouriteProducts = new List<Products>();
        }
        public void AddFavouriteProduct(Products product)
        {
            if(!FavouriteProducts.Contains(product))
            {
                FavouriteProducts.Add(product);
            }
        }
        public void RemoveFavouriteCake(Products product)
        {
            if(FavouriteProducts.Contains(product))
            {
                FavouriteProducts.Remove(product);
            }
        }
    }
}
