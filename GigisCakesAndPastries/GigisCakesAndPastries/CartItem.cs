using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public class CartItem
    {
        internal List<Cakes> Cake = new List<Cakes>();
        internal List<Pastries> Pastry = new List<Pastries>();
        public int Quantity { get; private set; }

        public CartItem(Products product, int quantity) 
        {
            this.Quantity = 0;
        }
    }
}
