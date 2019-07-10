namespace VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;
    public class Program
    {
        public static void Main()
        {
            var data = Console.ReadLine().Split();
            var vehicleCatalogue = new Vehicle();
            var areThereCars=false;
            var areThereTrucks=false;

            while (data[0] != "End")
            {
                var type = data[0];
                type = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(type.ToLower());
                var model = data[1];
                var color = data[2];
                var horsePower = double.Parse(data[3]);

                Console.WriteLine();

                if (type == "Car")
                {
                    var car = new Car { HorsePower = horsePower, Model=model, Type=type, Color=color };
                    vehicleCatalogue.Cars.Add(car);
                    areThereCars = true;
                }

                else
                {
                    var truck = new Truck { HorsePower = horsePower, Model = model, Type = type, Color = color };
                    vehicleCatalogue.Trucks.Add(truck);
                    areThereTrucks = true;
                }

                data = Console.ReadLine().Split();
            }


            var vehicleModel = Console.ReadLine();
            while (vehicleModel != "Close the Catalogue")
            {
                var modelIsCar = false;

                foreach (var car in vehicleCatalogue.Cars)
                {
                    if (car.Model == vehicleModel)
                    {
                        modelIsCar = true;
                        Console.WriteLine($"Type: {car.Type}");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                        break;
                    }
                }

                if (!modelIsCar)
                {
                    foreach (var truck in vehicleCatalogue.Trucks)
                    {
                        if (truck.Model == vehicleModel)
                        {
                            Console.WriteLine($"Type: {truck.Type}");
                            Console.WriteLine($"Model: {truck.Model}");
                            Console.WriteLine($"Color: {truck.Color}");
                            Console.WriteLine($"Horsepower: {truck.HorsePower}");
                            break;
                        }
                    }
                }

                vehicleModel = Console.ReadLine();
            }

            if (areThereCars)
            {
                double carsAverageHorsepower = 0;
                var carsHorsePowerList = new List<double>();
                foreach (var car in vehicleCatalogue.Cars)
                {
                    carsHorsePowerList.Add(car.HorsePower);
                }

                carsAverageHorsepower = carsHorsePowerList.Average();
                Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsepower:F2}.");
            }

            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }

            if (areThereTrucks)
            {
                double trucksAverageHorsepower = 0;
                var trucksHorsePowerList = new List<double>();
                foreach (var truck in vehicleCatalogue.Trucks)
                {
                    trucksHorsePowerList.Add(truck.HorsePower);
                }

                trucksAverageHorsepower = trucksHorsePowerList.Average();
                Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsepower:F2}.");
            }

            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }

        }
    }
    public class Vehicle
    {
        public Vehicle()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }


        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

    public class Car
    {
        public double HorsePower { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }

    public class Truck
    {
        public double HorsePower { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }
}
