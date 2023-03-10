namespace DeliveryOrders.Doamin.Entities
{
    public class Order : Basket

    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ClosedOn { get; set; }
        public int DeliverimanId { get; set; }
        public Deliveryman Deliveryman { get; set; }
        public string Status { get; set; }
        public List<Basket> ProductsList = new List<Basket>();

    }
}
