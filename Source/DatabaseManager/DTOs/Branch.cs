namespace HQTCSDL_Group01.DatabaseManager.DTOs
{
    public class Branch
    {
        public int ID { get; }
        public string Name { get; }
        public string Address { get; }

        public Branch(int id, string name, string add)
        {
            this.ID = id;
            this.Name = name;
            this.Address = add;
        }
    }
}