using DemoApp.Models;
using DemoApp.Repositories;

namespace DemoApp.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public Customer Create(string name)
        {
            return _customerRepository.Create(name);
        }

        public Customer Get(int Id)
        {
            return _customerRepository.Get(Id);
        }
    }
}
