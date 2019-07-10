namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var carsNumber = int.Parse(Console.ReadLine());
            var companyCars = new List<Car>();


            for (int i = 0; i < carsNumber; i++)
            {
                var carData = Console.ReadLine().Split();
                var model = carData[0];
                var engineSpeed = int.Parse(carData[1]);
                var enginePower = int.Parse(carData[2]);
                var cargoWeight = int.Parse(carData[3]);
                var cargoType = carData[4];

                var carEngine = new Engine
                {
                    Speed = engineSpeed,
                    Power = enginePower
                };

                var carCargo = new Cargo
                {
                    Weight = cargoWeight,
                    Type = cargoType
                };

                var car = new Car
                {
                    Model = model,
                    Engine = carEngine,
                    Cargo = carCargo
                };

                companyCars.Add(car);
            }

            var command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in companyCars.Where(x => x.Cargo.Type == "fragile").Where(x=>x.Cargo.Weight<1000))
                {
                    Console.WriteLine(car.Model);
                }
            }

            else
            {
                foreach (var car in companyCars.Where(x => x.Cargo.Type == "flamable").Where(x => x.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
      

}
