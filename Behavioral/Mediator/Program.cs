using Mediator.Windows;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var windowMediator = new WindowMediator();
            var optionsWindow = new OptionsWindow(windowMediator);
            optionsWindow.Send
            windowMediator.Broadcast("This is a broadcasted message to all windows");
            Console.WriteLine("Hello World!");
        }
    }
}
