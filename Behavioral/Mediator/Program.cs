using Mediator.Windows;
using System;

namespace Mediator
{
    internal class Program
    {
        private static void Main()
        {
            var windowMediator = new WindowMediator();
            var optionsWindow = new OptionsWindow(windowMediator);
            var userManagerWindow = new UserManagerWindow(windowMediator);
            var mainWindow = new MainWindow(windowMediator);

            optionsWindow.Notify("Notifying only options window!");
            windowMediator.Register(mainWindow);
            windowMediator.Register(optionsWindow);
            windowMediator.Register(userManagerWindow);

            windowMediator.Broadcast("This is a broadcasted message to all windows");
            Console.ReadKey();
        }
    }
}
