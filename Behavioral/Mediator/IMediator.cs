namespace Mediator
{
    internal interface IMediator
    {
        void Notify(Window window, string message);
        void Register(Window window);
        void Broadcast(string message);
    }
}
