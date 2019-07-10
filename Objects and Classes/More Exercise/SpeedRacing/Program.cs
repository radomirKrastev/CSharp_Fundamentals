namespace SpeedRacing
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var carsCount = int.Parse(Console.ReadLine());
            var Cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                var carData = Console.ReadLine().Split();
                var model = carData[0];
                var fuel = double.Parse(carData[1]);
                var fuelConsumption = double.Parse(carData[2]);

                var newCar = new Car()
                {
                    Model = model,
                    FuelAmount = fuel,
                    FuelConsumption = fuelConsumption,
                    Distance = 0
                    
                };

                Cars.Add(newCar);
            }

            var command = Console.ReadLine().Split();

            while (command[0] == "Drive")
            {
                var model = command[1];
                var travelDistance = double.Parse(command[2]);

                foreach (var car in Cars.Where(x => x.Model == model))
                {
                    var isDrivePossible= car.GetDriveResult(car.FuelAmount, car.FuelConsumption, travelDistance);
                    if (isDrivePossible)
                    {
                        car.FuelAmount = car.GetCarFuel(car.FuelAmount, car.FuelConsumption, travelDistance);
                        car.Distance = car.GetDriveDistance(travelDistance, car.Distance);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }

                command = Console.ReadLine().Split();
            }

            foreach (var car in Cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.Distance}");
            }
        }
    }


}
