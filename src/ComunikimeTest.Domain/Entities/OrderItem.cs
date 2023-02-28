namespace ComunikimeTest.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public OrderItem() : base()
        {

        }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int Amount { get; set; }

        public decimal Value { get; set; }
    }
}
