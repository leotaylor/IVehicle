using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSolid._Interface
{
    public interface IVehicle
    {
        int Wheels { get; }
        int Doors { get; }
        int PassengerCapacity { get; }
        bool Winged { get; }
        string TransmissionType { get; }
        double EngineVolume { get; }
        double MaxWaterSpeed { get; }
        double MaxLandSpeed { get; }
        double MaxAirSpeed { get; }

        void Start();
        void Stop();
        void Drive();
        void Fly();
    }
}
