using NoDependencyInjection.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDependencyInjection.Services
{
    public class CustomerService
    {
        private CustomerRepository _repository;

        public CustomerService()
        {
            _repository = new CustomerRepository();
        }

        public List<Customer> GetCustomers()
        {   
            return _repository.GetCustomers();
        }
    }
}
