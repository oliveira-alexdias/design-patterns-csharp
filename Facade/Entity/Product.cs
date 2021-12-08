namespace Facade.Entity
{
    public class Product
    {
        public Product(string name, int quantity, decimal unitPrice)
        {
            Quantity = quantity;
            UnitPrice = unitPrice;
            Name = name;
        }

        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}