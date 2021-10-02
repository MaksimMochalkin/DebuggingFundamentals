namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public bool Equals(Product? product)
        {
            if (product == null)
            {
                return false;
            }

            if (this.Name == product.Name && this.Price == product.Price)
            {
                return true;
            }

            return false;
        }
    }
}
