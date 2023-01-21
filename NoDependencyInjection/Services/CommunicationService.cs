using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDependencyInjection.Services
{
    public class CommunicationService
    {
        private EmailService _emailService;
        private SMSService _smsService;

        public CommunicationService() { 
            _emailService = new EmailService();
            _smsService = new SMSService();
        }

        public void SendMessage(Customer customer, string message)
        {
            //_emailService.Send(customer, message);
            _smsService.Send(customer, message);
        }
    }
}
