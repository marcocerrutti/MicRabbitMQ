using MediatR;
using MicRabbitMQ.Domain.Core.Bus;
using MicRabbitMQ.Domain.Core.Commands;
using MicRabbitMQ.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCRabbitMQ.Infra.Bus
{
    public sealed class RabbitMQBus : IEventBus
    {
        private readonly IMediator _mediator;

        public Task SendCommand<T>(T command) where T : Command
        {
           return _mediator.Send(command);
        }
        public void Publish<T>(T command) where T : Event
        {
            throw new NotImplementedException();
        }

        public void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>
        {
            throw new NotImplementedException();
        }
    }
}
