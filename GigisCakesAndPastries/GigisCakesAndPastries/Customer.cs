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
        public List<Cakes> FavouriteCakes = new List<Cakes>();
        public List<Pastries> FavouritePastries = new List<Pastries>();
        public List<CartItem> Cart = new List<CartItem>();
        public Customer(string id, string surname, string firstName, string middleName, string email, string username, string password, string phoneNumber, string address, string birthMonth, string birthDate, string birthYear, DateTime accountDateCreatead) : base(id, surname, firstName, middleName, email, username, password, phoneNumber, address, birthMonth, birthDate, birthYear, accountDateCreatead)
        {
            this.LoyaltyPoints = 0;
            FavouriteCakes = new List<Cakes>();
            FavouritePastries = new List<Pastries>();
        }

        public void AddToCart(Products product, int quantity)
        {
            CartItem item = new CartItem(product, quantity);
            Cart.Add(item);
        }
        public void RemoveFromCart(CartItem item)
        {
            Cart.Remove(item);
        }
        public void AddFavouriteCake(Cakes cakes)
        {
            if(!FavouriteCakes.Contains(cakes))
            {
                FavouriteCakes.Add(cakes);
            }
        }
        public void RemoveFavouriteCake(Cakes cakes)
        {
            if(FavouriteCakes.Contains(cakes))
            {
                FavouriteCakes.Remove(cakes);
            }
        }
        public void AddFavouritePastry(Pastries pastries)
        {
            if (!FavouritePastries.Contains(pastries))
            {
                FavouritePastries.Add(pastries);
            }
        }
        public void RemoveFavouritePastry(Pastries pastries)
        {
            if (FavouritePastries.Contains(pastries))
            {
                FavouritePastries.Remove(pastries);   
            }
        }
        public void Checkout()
        {
            if (Cart.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
                return;
            }
        }
    }
}
