using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSolid._Interface
{
    public interface ILandCraft : IVehicle
    {
        double MaxLandSpeed { get; }

        void Drive();
    }
}
