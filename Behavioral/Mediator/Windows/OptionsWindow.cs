using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Windows
{
    internal class OptionsWindow : Window
    {
        public OptionsWindow(IMediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{nameof(UserManagerWindow)}] {message}");
            Console.ForegroundColor = originalColor;
        }
    }
}
