using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public class Pastries : Products
    {
        public string Description { get; private set; }
        public Pastries(string productID, string name, string type, string size, double price, int quantity, string description) : base (productID, name, type, size, price, quantity)
        {
            this.Description = description;
        }
    }
}
