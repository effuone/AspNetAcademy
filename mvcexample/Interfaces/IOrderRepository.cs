using mvcexample.Models;

namespace mvcexample.Interfaces
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
        
    }
}