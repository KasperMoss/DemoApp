using DemoApp.Data;
using DemoApp.Models;
using System.Linq;

namespace DemoApp.Repositories
{
    public class CustomerRepository
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
    }
}
