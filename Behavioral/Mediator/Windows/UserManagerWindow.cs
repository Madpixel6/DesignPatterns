using System;

namespace Mediator.Windows
{
    internal class UserManagerWindow : Window
    {
        public UserManagerWindow(IMediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[{nameof(UserManagerWindow)}] {message}");
            Console.ForegroundColor = originalColor;
        }
    }
}
