using MicRabbitMQ.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicRabbitMQ.Domain.Core.Commands
{
    public abstract class Command: Message
    {
        public DateTime Time { get; protected set; }

        protected Command()
        {
            Time = DateTime.Now;
        }
    }
}
