using mvcexample.Interfaces;
using mvcexample.Models;

namespace mvcexample.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> PostAsync(Order model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Order model)
        {
            throw new NotImplementedException();
        }
    }
}