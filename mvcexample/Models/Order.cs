using System.Text.Json.Serialization;

namespace mvcexample.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        [JsonIgnore]
        public Customer Customer { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
