
using NoDependencyInjection.Services;

namespace NoDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {

            var customerService = new CustomerService();
            var CommunicationService = new CommunicationService();

            var customers = customerService.GetCustomers();

            var message = "Message to broadcast to all customers";

            foreach (var customer in customers)
            {
                CommunicationService.SendMessage(customer, message);
            }
        }
    }
}
