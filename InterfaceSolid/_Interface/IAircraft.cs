using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSolid._Interface
{
    public interface IAircraft : IVehicle
    {
        double MaxAirSpeed { get; }

        void Fly();
    }
}
