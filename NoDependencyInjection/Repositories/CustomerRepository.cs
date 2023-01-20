using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDependencyInjection.Repositories
{
    public class CustomerRepository
    {
        private MySQLConnection _connection;

        public CustomerRepository()
        { 
            _connection = new MySQLConnection();
        }

        public List<Customer> GetCustomers() 
        { 
            if(_connection.GetType() == typeof(MySQLConnection))
                Console.WriteLine("Get customers from MySQL");
            
            return new List<Customer>
            {
                new Customer() { Id=1, Name="Jesus Araujo", Email="jesus.araujo@coolechera.com", Phone="3016346643" },
                new Customer() { Id=2, Name="Roberto Mendez", Email="jesus.araujo@coolechera.com", Phone="3016346643" }
            };
        }
    }
}
