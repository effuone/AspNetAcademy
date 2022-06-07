namespace mvcexample.DTOs
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public AuthorDTO Author { get; set; }
        public decimal Price {get; set;}
    }
}