using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Windows
{
    class UserManagerWindow : Window
    {
        public UserManagerWindow(IMediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{nameof(UserManagerWindow)}] {message}");
            Console.ForegroundColor = originalColor;
        }
    }
}
