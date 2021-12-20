using System;
using System.Collections.Generic;
using System.Text;

namespace HQTCSDL_Group01.DatabaseManager.DTOs
{
    public class Order
    {
        public int OrderID { get; }
        public int BranchID { get; }
        public int ShipperID { get; }
        public int CustomerID { get; }
        public string ShippingMethod { get; }
        public string Address { get; }
        public string State { get; }
        public int ProductPrice { get; }
        public int ShippingPrice { get; }

        public Order(int orderID, int branchID, int customerID, int shipperID, string method, string address, string state, int productPrice, int shippingPrice)
        {
            this.OrderID = orderID;
            this.BranchID = branchID;
            this.CustomerID = customerID;
            this.ShipperID = shipperID;
            this.ShippingMethod = method;
            this.Address = address;
            this.State = state;
            this.ProductPrice = productPrice;
            this.ShippingPrice = shippingPrice;
        }
    }
}
