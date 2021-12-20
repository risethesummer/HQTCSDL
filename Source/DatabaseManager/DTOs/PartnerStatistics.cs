using System;
using System.Collections.Generic;
using System.Text;

namespace HQTCSDL_Group01.DatabaseManager.DTOs
{
    public class PartnerStatistics : Statistics
    {
        public ProductAmount MaxProduct { get; }

        public PartnerStatistics(TotalStatistics total, TotalStatistics shipping, TotalStatistics done, ProductAmount maxProduct) 
            : base(total, shipping, done)
        {
            this.MaxProduct = maxProduct;
        }
    }
}
