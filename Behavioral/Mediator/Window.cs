namespace Mediator
{
    internal abstract class Window
    {
        protected IMediator _mediator;
        public abstract void Notify(string message);

        protected Window(IMediator mediator)
            => _mediator = mediator;
    }
}
