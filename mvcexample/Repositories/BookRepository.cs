using mvcexample.Interfaces;
using mvcexample.Models;

namespace mvcexample.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> PostAsync(Book model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Book model)
        {
            throw new NotImplementedException();
        }
    }
}