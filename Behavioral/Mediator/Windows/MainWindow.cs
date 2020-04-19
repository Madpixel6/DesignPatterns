using System;

namespace Mediator.Windows
{
    internal class MainWindow : Window
    {
        public MainWindow(IMediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"[{nameof(MainWindow)}] {message}");
            Console.ForegroundColor = originalColor;
        }
    }
}
