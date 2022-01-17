using DemoApp.Models;

namespace DemoApp.Repositories
{
    public interface ICustomerRepository
    {
        public Customer Get(int id);
        public Customer Create(string name);
    }
}
