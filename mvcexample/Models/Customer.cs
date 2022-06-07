using System.ComponentModel.DataAnnotations.Schema;
using mvcexample.Context;
using Newtonsoft.Json;

namespace mvcexample.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string UserId {get; set;}

        [ForeignKey("UserId")]
        [JsonIgnore]     
        public BookStoreUser User {get; set;}
        public IEnumerable<Order> Orders {get; set;}
    }
}