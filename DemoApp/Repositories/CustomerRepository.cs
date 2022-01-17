using DemoApp.Data;
using DemoApp.Models;
using System.Linq;

namespace DemoApp.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _context;

        public CustomerRepository (CustomerContext context)
        {
            _context = context;
        }

        public Customer Get(int id)
        {
            return _context.Customers.FirstOrDefault(c => c.Id == id);
        }

        public Customer Create(string name)
        {
            Customer customer = new Customer { Name = name };
            var entity = _context.Customers.Add(customer);
            _context.SaveChanges();
            return entity.Entity;
        }
    }
}
