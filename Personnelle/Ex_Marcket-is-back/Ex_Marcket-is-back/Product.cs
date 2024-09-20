namespace Ex_Marcket_is_back
{
     internal class Product
    {
        public Product()
        {
        }

        public Product(int location, string producer, string productName, int quantity, string unit, double pricePerUnit)
        {
            Location = location;
            Producer = producer;
            ProductName = productName;
            Quantity = quantity;
            Unit = unit;
            PricePerUnit = pricePerUnit;
        }

        public int Location { get;  set; }
        public string Producer { get;  set; }
        public string ProductName { get;  set; }
        public int Quantity { get;  set; }
        public string Unit { get;  set; }
        public double PricePerUnit { get;  set; }
    }
}