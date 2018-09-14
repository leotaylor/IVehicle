using System;
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

            // With a single `foreach`, have each vehicle Fly()



            // Build a collection of all vehicles that operate on roads
            var motorcycle = new Motorcycle();
            var ambulance = new Ambulance();

            // With a single `foreach`, have each road vehicle Drive()



            // Build a collection of all vehicles that operate on water
            var jetSki = new JetSki();
            var ferry = new Ferry();

            // With a single `foreach`, have each water vehicle Drive()
        }

    }
}
