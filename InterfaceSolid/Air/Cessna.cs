using System;
using System.Collections.Generic;
using System.Text;
using InterfaceSolid._Interface;

namespace InterfaceSolid.Air
{
    public class Cessna : IAircraft
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 3;
        public int PassengerCapacity { get; set; } = 4;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 31.1;
        public double MaxAirSpeed { get; set; } = 309.0;

        public void Fly()
        {
            Console.WriteLine("The Cessna almost effortlessly glides through the clouds pretending it is a gleaming god of the Sun");
        }

        public void Start()
        {
            Console.WriteLine("After several attempts, the Cessna fires up.");
        }

        public void Stop()
        {
            Console.WriteLine("Uh oh, the Cessna Engine Stalled out.");
        }
    }
}
