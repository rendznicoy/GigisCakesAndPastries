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
        public string ProductName { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Variant { get; set; }

        public Products(string productID, string productName, string type, string size, double price, int quantity, string variant)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.Type = type;
            this.Size = size;
            this.Price = price;
            this.Quantity = quantity;
            this.Variant = variant;
        }
    }
}
