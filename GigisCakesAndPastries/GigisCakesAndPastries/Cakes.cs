using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public class Cakes : Products
    {
        public Cakes(string productID, string productName, string type, string size, double price, int quantity, string variant) : base(productID, productName, type, size, price, quantity, variant)
        {

        }
    }
}
