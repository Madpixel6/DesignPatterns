using System;

namespace Mediator.Windows
{
    internal class OptionsWindow : Window
    {
        public OptionsWindow(IMediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{nameof(OptionsWindow)}] {message}");
            Console.ForegroundColor = originalColor;
        }
    }
}
