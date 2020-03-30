using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.MakeCars();

            Console.ReadKey();
        }
    }
}
