using System;
using System.Collections.Generic;
using System.Text;

namespace HQTCSDL_Group01.DatabaseManager.DTOs
{
    public class Statistics
    {
        public TotalStatistics Total;
        public TotalStatistics Shipping;
        public TotalStatistics Done;
        public Statistics(TotalStatistics total, TotalStatistics shipping, TotalStatistics done)
        {
            this.Total = total;
            this.Shipping = shipping;
            this.Done = done;
        }
    }
}
