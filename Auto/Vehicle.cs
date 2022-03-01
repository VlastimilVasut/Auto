using System;
using System.Collections.Generic;
using System.Text;

namespace Auto
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Fuel { get; set; }
        public double EngineVolume { get; set; }
        public int FuelLevel { get; set; }
        public int  Distance { get; set; }
        public int PneuState { get; set; }

        public Vehicle()
        {
            Type = "Unknown";
            Brand = "Unknown";
            Fuel = "Gas";
            EngineVolume = 1000;
            FuelLevel = 100;
            Distance = 0;
            PneuState = 100;
         }
    }
}
