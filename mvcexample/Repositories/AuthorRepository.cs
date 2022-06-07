using mvcexample.Interfaces;
using mvcexample.Models;

namespace mvcexample.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Author>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Author> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> PostAsync(Author model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Author model)
        {
            throw new NotImplementedException();
        }
    }
}