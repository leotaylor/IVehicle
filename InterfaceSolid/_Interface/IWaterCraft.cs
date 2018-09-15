using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSolid._Interface
{
    interface IWaterCraft : IVehicle
    {
        double MaxWaterSpeed { get; }

        void Drive();
    }
}
