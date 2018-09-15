using System;
using System.Collections.Generic;
using InterfaceSolid._Interface;
using InterfaceSolid.Air;
using InterfaceSolid.Ground;
using InterfaceSolid.Water;

namespace InterfaceSolid
{
    public class Program
    {
        public static void Main()
        {

            // Build a collection of all vehicles that fly
            var cessna = new Cessna();
            var archer = new PiperArcher();

            var airVehicles = new List<IAircraft> { cessna, archer };

            // With a single `foreach`, have each vehicle Fly()

            foreach(var aircraft in airVehicles)
            {
                aircraft.Fly();
            }



            // Build a collection of all vehicles that operate on roads
            var motorcycle = new Motorcycle();
            var ambulance = new Ambulance();

            var landVehicles = new List<ILandCraft> { motorcycle, ambulance };

            // With a single `foreach`, have each road vehicle Drive()

            foreach(var vehicle in landVehicles)
            {
                vehicle.Drive();
            }



            // Build a collection of all vehicles that operate on water
            var jetSki = new JetSki();
            var ferry = new Ferry();

            var waterVehicles = new List<IWaterCraft> { jetSki, ferry };

            // With a single `foreach`, have each water vehicle Drive()
            
            foreach(var waterCraft in waterVehicles)
            {
                waterCraft.Drive();
            }
            Console.ReadLine();
        }

    }
}
