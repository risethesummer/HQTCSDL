using System;
using System.Collections.Generic;
using System.Text;

namespace HQTCSDL_Group01.DatabaseManager.DTOs
{
    public class ProductAmount
    {
        public Product Product { get; }
        public int Amount { get; }

        public ProductAmount(Product product, int amount)
        {
            this.Product = product;
            this.Amount = amount;
        }
    }
}
