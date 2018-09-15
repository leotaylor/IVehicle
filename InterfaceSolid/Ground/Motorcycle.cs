using System;
using System.Collections.Generic;
using System.Text;
using InterfaceSolid._Interface;

namespace InterfaceSolid.Ground
{
    public class Motorcycle : ILandCraft
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 1;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxLandSpeed { get; set; } = 160.4;

        public void Drive()
        {
            Console.WriteLine("The motorcycle screams down the highway");
        }

        public void Start()
        {
            Console.WriteLine("The Motorcycle Fires up.");
        }

        public void Stop()
        {
            Console.WriteLine("The Motorcycle skids to a stop.");
        }
    }

}
