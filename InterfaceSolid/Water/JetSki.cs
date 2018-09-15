using System;
using System.Collections.Generic;
using System.Text;
using InterfaceSolid._Interface;

namespace InterfaceSolid.Water
{
    public class JetSki : IWaterCraft
    {
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 2;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 20;
        public double MaxWaterSpeed { get; set; } = 110;

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
        }

        public void Start()
        {
            Console.WriteLine("The JetSki Fires right up.");
        }

        public void Stop()
        {
            Console.WriteLine("The JetSki driven by Jason Stathom gets eaten by a Megalodon.");
        }
    }
}
