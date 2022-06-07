using mvcexample.Interfaces;
using mvcexample.Models;

namespace mvcexample.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> PostAsync(Customer model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Customer model)
        {
            throw new NotImplementedException();
        }
    }
}