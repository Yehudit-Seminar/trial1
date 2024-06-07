namespace ex1
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }

        public Products(int id, string name, string category, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Price = price;
        }
        public Products() { }
    }
}
