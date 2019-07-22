namespace FeedTheAnimals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var animals = new Dictionary<string, Dictionary<string,int>>();

            var input = Console.ReadLine();

            while (input != "Last Info")
            {
                var command = input.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                var name = command[1];
                var area = command[3];
                var additionalData = new Dictionary<string, int>();

                if (command[0] == "Add")
                {                    
                    var foodLimit = int.Parse(command[2]);
                    
                    if (!animals.ContainsKey(name))
                    {                        
                        additionalData.Add(area,0);
                        animals.Add(name, additionalData);
                    }

                    additionalData = animals[name];
                    additionalData[area] += foodLimit;
                    animals[name] = additionalData;
                }

                else
                {
                    var foodEaten = int.Parse(command[2]);

                    if (animals.ContainsKey(name))
                    {
                        additionalData = animals[name];
                        additionalData[area] -= foodEaten;

                        if (additionalData[area] <= 0)
                        {
                            Console.WriteLine(name+" was successfully fed");
                            animals.Remove(name);
                        }

                        else
                        {
                            animals[name] = additionalData;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            var animalFood = new Dictionary<string, int>();

            foreach (var animal in animals)
            {
                foreach (var food in animal.Value)
                {
                    animalFood.Add(animal.Key, food.Value);
                }
            }

            Console.WriteLine("Animals:");
            foreach (var animal in animalFood.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{animal.Key} -> {animal.Value}g");
            }

            var areaAnimals = new Dictionary<string, int>();

            foreach (var animal in animals)
            {                
                foreach (var area in animal.Value)
                {
                    if (!areaAnimals.ContainsKey(area.Key))
                    {
                        areaAnimals.Add(area.Key, 0);
                    }

                    areaAnimals[area.Key] += 1;
                }
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var animal in areaAnimals.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{animal.Key} : {animal.Value}");
            }
        }
    }
}
