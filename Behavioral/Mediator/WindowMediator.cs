using Mediator.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    internal class WindowMediator : IMediator
    {
        private List<Window> windows;
        public WindowMediator()
        {
            windows = new List<Window>();
        }
        public void Register(Window window)
            => windows.Add(window);
        public void Notify(Window window, string message)
        {
            var destinationWindow = windows.Find(w => w.Equals(window));
            if (destinationWindow is null)
                throw new InvalidOperationException("Tried to notify unregistered window");
            destinationWindow.Notify(message);
        }

        public void Broadcast(string message)
        {
            if (windows is null || windows.Count < 1)
                throw new InvalidOperationException("Tried to notify unregistered window");
            foreach (var window in windows)
                window.Notify("Message");
        }
    }
}
