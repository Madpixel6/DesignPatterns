using System;

namespace Facade
{
    internal class CoderWorkFacade
    {
        private readonly Coder _coder;
        private readonly VendingMachine _vendingMachine;
        private readonly Bed _bed;
        private readonly Random _random = new Random();

        public CoderWorkFacade(Coder coder, Bed bed, VendingMachine vendingMachine)
        {
            _coder = coder;
            _bed = bed;
            _vendingMachine = vendingMachine;
        }

        public void GetUp()
        {
            Console.WriteLine("Waking up");
            _bed.Arrange();
            Console.WriteLine("Taking a walk to work..");
            _coder.Stamina -= _random.Next(0, 2);
        }

        public void GoHome()
        {
            Console.WriteLine("Taking a walk to home");
            if (_coder.Stamina < 2)
            {
                Console.WriteLine("Stopping at a nearby shop to buy something to drink");
                _coder.Stamina += _vendingMachine.GetSomethingToDrink();
            }

            while (_coder.Stamina > 0.5)
            {
                Console.WriteLine("Playing some games at home ;)");
                _coder.Stamina -= _random.Next(1, 4);
            }
            Console.WriteLine("Going to sleep...");
            _bed.Sleep();
        }
        public void WorkForSomeTime()
        {
            Console.WriteLine($"{_coder.Name} has started working");
            if (_coder.Stamina < 10)
            {
                _vendingMachine.GetEnergyDrink();
            }
            while (_coder.Stamina > 1)
            {
                _coder.Work();
            }
        }

    }
}
