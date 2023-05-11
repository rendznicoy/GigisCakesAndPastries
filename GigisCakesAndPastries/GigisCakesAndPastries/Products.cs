using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public class Products
    {
        public string ProductID { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Size { get; private set; }
        public double Price { get; set; }
        public int Quantity { get; private set; }

        public Products(string productID, string name, string type, string size, double price, int quantity)
        {
            this.ProductID = productID;
            this.Name = name;
            this.Type = type;
            this.Size = size;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
