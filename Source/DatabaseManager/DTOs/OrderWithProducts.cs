using System;
using System.Collections.Generic;
using System.Text;

namespace HQTCSDL_Group01.DatabaseManager.DTOs
{
    public class OrderWithProducts : Order
    {
        public IEnumerable<ProductAmount> Products { get; }

        public OrderWithProducts(IEnumerable<ProductAmount> products, int orderID, int branchID, int customerID, int shipperID, string method, string address, string state, int productPrice, int shippingPrice) 
            : base(orderID, branchID, customerID, shipperID, method, address, state, productPrice, shippingPrice)
        {
            this.Products = products;
        }
    }
}
