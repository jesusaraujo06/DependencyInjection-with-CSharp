// See https://aka.ms/new-console-template for more information

using WithDepedencyInjection.Repositories;
using WithDependencyInjection.Repositories;
using WithDependencyInjection.Services;

class Program
{
    static void Main(string[] args)
    {
        // Dependencias

        // Aqui si instanciamos las dependencias que quiero usar, y luego las vamos a inyectar.
        var sender = new EmailService();
        // Instanciamos el connection
        var dbConnection = new OracleConnection();
        // Instanciamos el repository
        var repository = new CustomerRepository(dbConnection);

        // Instanciamos los servicios y pasamos las dependencias por parametro
        var customerService = new CustomerService(repository);
        var communicationService = new CommunicationService(sender);

        Console.WriteLine("With Dependency Injection");

        var customers = customerService.GetCustomers();

        var message = "Message to broadcast to all customers";

        foreach (var customer in customers)
        {
            communicationService.SendMessage(customer, message);
        }
    }
}
