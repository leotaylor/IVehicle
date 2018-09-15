using System;
using System.Collections.Generic;
using System.Text;
using InterfaceSolid._Interface;

namespace InterfaceSolid.Air
{
    public class PiperArcher : IAircraft
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 3;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 32.1;
        public double MaxAirSpeed { get; set; } = 410.0;

        public void Fly()
        {
            Console.WriteLine("The Archer effortlessly glides through the clouds like a gleaming god of the Sun");
        }

        public void Start()
        {
            Console.WriteLine("The Archer Fires right up.");
        }

        public void Stop()
        {
            Console.WriteLine("The Archer lands safely.");
        }
    }
}
