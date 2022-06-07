using mvcexample.Models;

namespace mvcexample.Interfaces
{
    public interface ICustomerRepository : IAsyncRepository<Customer>
    {
        
    }
}