namespace DeliveryOrders.Doamin.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public double Price { get; set; }
        public string Unit { get; set; }
    }
}
