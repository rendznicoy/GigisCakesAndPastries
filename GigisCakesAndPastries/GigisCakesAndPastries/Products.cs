using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public class Products
    {
        internal List<Cakes> Cakes= new List<Cakes>();
        internal List<Pastries> Pastries = new List<Pastries>();
        public string ProductID { get; private set; }
        public string ProductName { get; private set; }
        public string Type { get; private set; }
        public string Size { get; private set; }
        public double Price { get; set; }
        public int Quantity { get; private set; }
        public string Variant { get; private set; }

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
