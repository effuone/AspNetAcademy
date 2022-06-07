using mvcexample.Models;

namespace mvcexample.Interfaces
{
    public interface IBookRepository : IAsyncRepository<Book>
    {
        
    }
}