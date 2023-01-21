using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithDependencyInjection;

namespace WithDepedencyInjection.Services
{
    public interface ISender
    {
        void Send(Customer customer, string message);
    }
}
