namespace HQTCSDL_Group01.DatabaseManager
{
    public class Product
    {
        public int ID { get; }
        public string Name { get; }
        public string Description { get; }
        public long Price { get; }

        public Product(string name, string des, long price)
        {
            this.Name = name;
            this.Description = des;
            this.Price = price;
        }

        public Product(int id, string name, string des, long price) : this(name, des, price)
        {
            this.ID = id;
        }
    }

}