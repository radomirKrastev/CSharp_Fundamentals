namespace VehicleCatalog
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var catalog = new Catalog();
            var commandData = Console.ReadLine().Split('/');

            while (commandData[0] != "end")
            {
                var type = commandData[0];
                var brand = commandData[1];
                var model = commandData[2];
                if (type == "Car")
                {
                    var horsePower = double.Parse(commandData[3]);
                    var car = new Car()
                    {
                        Brand = brand,
                        Model=model,
                        HorsePower=horsePower
                    };

                    catalog.Cars.Add(car);
                }

                else
                {
                    var weight = double.Parse(commandData[3]);
                    var truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };

                    catalog.Trucks.Add(truck);
                }
                
                commandData= Console.ReadLine().Split('/');
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            
        }
    }
}
