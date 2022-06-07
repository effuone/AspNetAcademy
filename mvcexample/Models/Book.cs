using System.Text.Json.Serialization;

namespace mvcexample.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public int Price { get; set; }
    }
}
