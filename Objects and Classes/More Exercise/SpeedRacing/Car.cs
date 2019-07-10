using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {      
        
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double Distance { get; set; }

        public bool GetDriveResult(double fuelAmount, double consumption, double driveDistance)
        {
            var isTravelPossible = false;
            var fuelNeeded = driveDistance * consumption;
            
            if (fuelNeeded <= fuelAmount)
            {
                isTravelPossible = true;
            }
            return isTravelPossible;
        }

        public double GetDriveDistance(double driveDistance, double totalDistance)
        {
            return totalDistance += driveDistance;
        }

        public double GetCarFuel(double fuelAmount, double consumption, double driveDistance)
        {
            return fuelAmount -= driveDistance * consumption;
        }
    }
}
