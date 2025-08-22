namespace Udemy_Session_08.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }   
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product )
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product}, Quantity: {Quantity}, "
                    + $"Subtotal: ${SubTotal():F2}";
        }
    }
}
