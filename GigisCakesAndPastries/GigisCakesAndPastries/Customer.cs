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
        public List<CartItem> Cart = new List<CartItem>();
        public Customer(string id, string surname, string firstName, string middleName, string email, string username, string password, string phoneNumber, string address, string birthMonth, string birthDate, string birthYear, DateTime accountDateCreatead) : base(id, surname, firstName, middleName, email, username, password, phoneNumber, address, birthMonth, birthDate, birthYear, accountDateCreatead)
        {
            this.LoyaltyPoints = 0;
            FavouriteProducts = new List<Products>();
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
