using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public class Cakes : Products
    {
        public string Flavor { get; set; }
        public Cakes(string productID, string name, string type, string size, double price, int quantity, string flavor) : base(productID, name, type, size, price, quantity)
        {
            this.Flavor = flavor;
        }
    }
}
