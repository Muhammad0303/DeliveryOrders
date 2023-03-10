namespace DeliveryOrders.Doamin.Entities
{
    public class Basket : EntityBase
    {
        public static int counter = 0;
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Count { get; set; }
        public Basket()
        {
            counter++;
        }
    }
}
