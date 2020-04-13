using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    enum ShipClass
    {
        Corvette,
        Destroyer,
        Submarine
    }
    internal interface IShip
    {
        void Sail();
        void SpeedUp();
        void SlowDown();
        ShipClass ShipClass { get; set; }
    }
}
