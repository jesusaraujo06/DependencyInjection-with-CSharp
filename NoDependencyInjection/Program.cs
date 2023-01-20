// See https://aka.ms/new-console-template for more information

using NoDependencyInjection.Services;

var customerService = new CustomerService();
var CommunicationService = new CommunicationService();

var customers = customerService.GetCustomers();

var message = "Message to broadcast to all customers";

foreach (var customer in customers)
{
    CommunicationService.SendMessage(customer, message);
}
