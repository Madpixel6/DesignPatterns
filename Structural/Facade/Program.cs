using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var bed = new Bed();
            var vendingMachine = new VendingMachine();
            var coder = new Coder("Tony");

            var coderWorkFacade = new CoderWorkFacade(coder, bed, vendingMachine);
            coderWorkFacade.GetUp();
            coderWorkFacade.WorkForSomeTime();
            coderWorkFacade.GoHome();
            Console.WriteLine($"At the end of the day, our coder has got {coder.Money} money");
            Console.ReadKey();
        }
    }
}
