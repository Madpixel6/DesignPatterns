using System;

namespace Facade
{
    internal class Coder
    {
        public readonly string Name;
        public int Money { get; set; }
        public float Stamina { get; set; }

        public Coder(string name)
        {
            Name = name;
            Money = 0;
            Stamina = 10;
        }

        public void Work()
        {
            Console.WriteLine("Working...");
            Stamina -= 1;
            Money += 10;
        }
    }
}
