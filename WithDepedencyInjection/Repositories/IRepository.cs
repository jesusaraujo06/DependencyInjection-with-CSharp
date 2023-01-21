using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithDependencyInjection;

namespace WithDepedencyInjection.Repositories
{
    public interface IRepository
    {
        List<Customer> GetCustomers();
    }
}
