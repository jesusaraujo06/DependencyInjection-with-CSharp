using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithDepedencyInjection.Repositories;

namespace WithDependencyInjection.Repositories
{
    public class CustomerRepository : IRepository
    {
        private IDbConnection _dbConnection;

        public CustomerRepository(IDbConnection dbConnection)
        { 
            _dbConnection= dbConnection;
        }

        public List<Customer> GetCustomers() 
        { 
            if(_dbConnection.GetType() == typeof(MySQLConnection))
                Console.WriteLine("Get customers from MySQL");

            else if (_dbConnection.GetType() == typeof(OracleConnection))
                Console.WriteLine("Get customers from Oracle");

            return new List<Customer>
            {
                new Customer() { Id=1, Name="Jesus Araujo", Email="jesus.araujo@coolechera.com", Phone="3016346643" },
                new Customer() { Id=2, Name="Roberto Mendez", Email="jesus.araujo@coolechera.com", Phone="3016346643" }
            };
        }
    }
}
