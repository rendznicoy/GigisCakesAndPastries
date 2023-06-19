using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public class Orders
    {
        public string OrderID { get; private set; }
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerAddress { get; set; }
        public string ProductName { get; set; }
        public string ProductSize { get; set; }
        public string OrderOption { get; set; }
        public string PaymentOption { get; set; }
        public int OrderQuantity { get; set; }
        public double OrderTotal { get; set; }
        public DateTime OrderDate { get; set; }

        public Orders(string orderID, string customerName, string customerPhoneNumber, string customerAddress, string productName, string productSize, string orderOption, string paymentOption, int orderQuantity, double orderTotal, DateTime orderDate)
        {
            this.OrderID = orderID;
            this.CustomerName = customerName;
            this.CustomerPhoneNumber = customerPhoneNumber;
            this.CustomerAddress = customerAddress;
            this.ProductName = productName;
            this.ProductSize = productSize;
            this.OrderOption = orderOption;
            this.PaymentOption = paymentOption;
            this.OrderQuantity = orderQuantity;
            this.OrderTotal = orderTotal;
            this.OrderDate = orderDate;
        }
    }
}
