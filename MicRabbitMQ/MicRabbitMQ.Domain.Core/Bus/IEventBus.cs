using MicRabbitMQ.Domain.Core.Commands;
using MicRabbitMQ.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicRabbitMQ.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T: Command;
        void Publish<T>(T command) where T: Event;

        void Subscribe<T, TH>() 
            where T: Event 
            where TH: IEventHandler<T>;
    }
}
