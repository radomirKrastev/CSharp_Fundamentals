namespace VehicleCatalogue
{
    using System.Collections.Generic;
    public class Vehicle
    {
        public Vehicle()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }


        public List<Car> Cars{get; set;}
        public List<Truck> Trucks{get; set;}
    }
}
