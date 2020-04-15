using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Windows
{
    internal class MainWindow : Window
    {
        public MainWindow(IMediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            throw new NotImplementedException();
        }
    }
}
