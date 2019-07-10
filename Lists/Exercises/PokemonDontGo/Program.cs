namespace PokemonDontGo
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            List<int> distanceData = Console.ReadLine().Split().Select(int.Parse).ToList();

            int removedElementsValue = 0;
            while (distanceData.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                removedElementsValue += GetRemovedElementsValue(distanceData, removedElementsValue, index);
                distanceData = ChangeData(distanceData, index);
            }

            Console.WriteLine(removedElementsValue);
        }

        public static List <int> ChangeData(List<int>distanceData, int index)
        {
            
            int capturedPokemonValue=0;

            if (index < 0)
            {
                capturedPokemonValue = distanceData[0];
                distanceData[0] = distanceData[distanceData.Count - 1];
            }
            else if (index > distanceData.Count - 1)
            {
                capturedPokemonValue = distanceData[distanceData.Count - 1];
                distanceData[distanceData.Count - 1] = distanceData[0];
            }
            else
            {
                capturedPokemonValue = distanceData[index];
                distanceData.RemoveAt(index);
            }
            
            for (int i = 0; i < distanceData.Count; i++)
            {
                if (distanceData[i] <= capturedPokemonValue)
                {
                    distanceData[i] += capturedPokemonValue;
                }

                else
                {
                    distanceData[i] -= capturedPokemonValue;
                }
            }

            return distanceData;
        }
        
        public static int GetRemovedElementsValue(List<int> distanceData, int removedElementsValue, int index)
        {
            if (index < 0)
            {
                removedElementsValue = distanceData[0];
            }
            else if (index > distanceData.Count - 1)
            {
                removedElementsValue = distanceData[distanceData.Count - 1];
            }
            else
            {
                removedElementsValue = distanceData[index];
               
            }

            return removedElementsValue;
        }
    }
}
