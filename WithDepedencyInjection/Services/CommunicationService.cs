using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithDepedencyInjection.Services;

namespace WithDependencyInjection.Services
{
    public class CommunicationService
    {
        private ISender _sender;

        // Recibir por parametros el servicio sender, aqui no necesitamos instanciar nada con new()
        // Con esto, la dependencia sender, está siendo inyectada a la clase ComunicationService, a traves del constructor
        // Entonces desde la capa de arriba, en este proyecto seria Program.cs, vamos a definir cual es el sender que este servicio va a utilizar.
        public CommunicationService(ISender sender) 
        {
            _sender = sender;
        }

        public void SendMessage(Customer customer, string message)
        {
            //_emailService.Send(customer, message);
            _sender.Send(customer, message);
        }
    }
}
