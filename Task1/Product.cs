using System.Reflection.Metadata;

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

            return product.Name == this.Name && product.Price == this.Price;
        }
    }
}
