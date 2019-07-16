namespace FeedTheAnimals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var animals = new Dictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();

            while(input!= "Last Info")
            {
                var command = input.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                var nameAnimal = command[1];
                var area = command[3];

                if (command[0] == "Add")
                {                    
                    var foodLimit = int.Parse(command[2]);                    

                    if (!animals.ContainsKey(nameAnimal))
                    {
                        var initialData = new Dictionary<string, int>();
                        initialData.Add(area, 0);
                        animals.Add(nameAnimal, initialData);
                    }

                    var animalData = animals[nameAnimal];
                    animalData[area] += foodLimit;
                    animals[nameAnimal] = animalData;
                }

                else
                {
                    var foodEaten = int.Parse(command[2]);

                    if (animals.ContainsKey(nameAnimal))
                    {
                        var animalData = animals[nameAnimal];
                        animalData[area] -= foodEaten;
                        if (animalData[area] <= 0)
                        {
                            Console.WriteLine(nameAnimal+" was successfully fed");
                            animals.Remove(nameAnimal);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            var animalFood = new Dictionary<string, int>();
            var hungryAnimalsAreas = new Dictionary<string,int>();
            foreach (var animal in animals)
            {
                foreach (var animalValue in animal.Value)
                {
                    animalFood.Add(animal.Key, animalValue.Value);
                    if (!hungryAnimalsAreas.ContainsKey(animalValue.Key))
                    {
                        hungryAnimalsAreas.Add(animalValue.Key, 0);
                    }

                    hungryAnimalsAreas[animalValue.Key]++;
                }                
            }

            Console.WriteLine("Animals:");
            foreach (var animal in animalFood.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine(animal.Key+" -> "+animal.Value+"g");
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var area in hungryAnimalsAreas.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine(area.Key+" : "+area.Value);
            }
        }
    }
}
