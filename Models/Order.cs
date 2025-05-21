namespace be_poc.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Client { get; set; }
        public string Product { get; set; }
        public float Value { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}