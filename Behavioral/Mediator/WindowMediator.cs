using System;
using System.Collections.Generic;

namespace Mediator
{
    internal class WindowMediator : IMediator
    {
        private readonly List<Window> _windows;
        public WindowMediator()
            => _windows = new List<Window>();
        public void Register(Window window)
            => _windows.Add(window);
        public void Notify(Window window, string message)
        {
            var destinationWindow = _windows.Find(w => w.Equals(window));
            if (destinationWindow is null)
                throw new InvalidOperationException("Tried to notify unregistered window");
            destinationWindow.Notify(message);
        }

        public void Broadcast(string message)
        {
            if (_windows is null || _windows.Count < 1)
                throw new InvalidOperationException("Tried to notify unregistered window");
            foreach (var window in _windows)
                window.Notify(message);
        }
    }
}
