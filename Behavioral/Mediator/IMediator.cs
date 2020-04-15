using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    interface IMediator
    {
        void Notify(Window window, string message);
        void Register(Window window);
        void Broadcast(string message);
    }
}
