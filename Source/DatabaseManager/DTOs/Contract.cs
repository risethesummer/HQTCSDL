using System;

namespace HQTCSDL_Group01.DatabaseManager
{
    public class Contract
    {
        public int ID { get; }
        public string Tax { get; }
        public string Representation { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public Contract(int id, string tax, string rep, DateTime start, DateTime end)
        {
            this.ID = id;
            this.Tax = tax;
            this.Representation = rep;
            this.StartDate = start;
            this.EndDate = end;
        }
    }
}