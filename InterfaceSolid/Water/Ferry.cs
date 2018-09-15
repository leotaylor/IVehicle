using System;
using System.Collections.Generic;
using System.Text;
using InterfaceSolid._Interface;

namespace InterfaceSolid.Water
{
    class Ferry : IWaterCraft
    {
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 1;
        public int PassengerCapacity { get; set; } = 50;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 40;
        public double MaxWaterSpeed { get; set; } = 25;

        public void Drive()
        {
            Console.WriteLine("The ferry trudges through the waves with the greatest of difficulty");
        }

        public void Start()
        {
            Console.WriteLine("The Ferry's engine is running");
        }

        public void Stop()
        {
            Console.WriteLine("The Ferry arrived at the other side of the lake.");
        }
    }
}
