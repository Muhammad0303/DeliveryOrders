using System;

namespace DeliveryOrders.Doamin.Entities
{
    public class Person : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
