using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    internal abstract class Window
    {
        protected IMediator _mediator;
        public abstract void Notify(string message);
        public Window(IMediator mediator)
            => _mediator = mediator;
    }
}
