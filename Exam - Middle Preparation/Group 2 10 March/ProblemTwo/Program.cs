namespace ProblemTwo
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var fireCellsData = Console.ReadLine().Split('#').ToList();
            var waterSupply = int.Parse(Console.ReadLine());
            double effort = 0;
            var cellsCleared = new List<int>();
            for (int i = 0; i < fireCellsData.Count; i++)
            {
                if (waterSupply > 0)
                {
                    var cellData = fireCellsData[i].Split(new char[] { '=',' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var fireType = cellData[0];
                    var cellValue = int.Parse(cellData[1]);
                    var validValue = IsValueValid(fireType, cellValue);

                    if (waterSupply >= cellValue && validValue)
                    {
                        cellsCleared.Add(cellValue);
                        waterSupply -= cellValue;
                        effort += 0.25 * cellValue;
                    }

                    else
                    {
                        continue;
                    }
                }

                else
                {
                    break;
                }
            }

            Console.WriteLine("Cells:");
            if (cellsCleared.Count >= 1)
            {
                Console.WriteLine(" - " + string.Join(Environment.NewLine + " - ", cellsCleared));
            }
            
            Console.WriteLine($"Effort: {effort:F2}");
            Console.WriteLine($"Total Fire: {cellsCleared.Sum()}");

        }

        public static bool IsValueValid(string type, int value)
        {
            var validValue = false;
            if (type == "High")
            {
                if (value >= 81 && value <= 125)
                {
                    validValue = true;
                }
            }

            else if (type == "Medium")
            {
                if (value >= 51 && value <= 80)
                {
                    validValue = true;
                }
            }

            else //(type == "Low")
            {
                if (value >= 1 && value <= 50)
                {
                    validValue = true;
                }
            }

            return validValue;
        }
    }
}
