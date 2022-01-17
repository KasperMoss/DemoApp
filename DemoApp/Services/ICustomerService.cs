using DemoApp.Models;

namespace DemoApp.Services
{
    public interface ICustomerService
    {
        Customer Get(int Id);

        Customer Create(string name);
    }
}
