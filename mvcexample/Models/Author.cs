using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using mvcexample.Context;

namespace mvcexample.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string UserId {get; set;}

        [ForeignKey("UserId")]
        [JsonIgnore]     
        public BookStoreUser User {get; set;}
        public IEnumerable<Book> Books { get; set; }
    }
}