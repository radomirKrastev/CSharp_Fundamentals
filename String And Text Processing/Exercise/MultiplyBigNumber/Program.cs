namespace MultiplyBigNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var symbols = Console.ReadLine().TrimStart(new char[] { '0' });
            var numbers = new List<int>();

            foreach (var c in symbols)
            {
                var str = c.ToString();
                var number = int.Parse(str);
                numbers.Add(number);
            }
            
            var multiplyer = int.Parse(Console.ReadLine());
            var leftover = 0;

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                var result = numbers[i] * multiplyer+leftover; 

                if (result.ToString().Length == 1)
                {
                    numbers[i] = result;
                    leftover = 0;
                }

                else if (result.ToString().Length != 1 && i!=0)
                {
                    numbers[i] = result % 10;
                    leftover = result / 10;                    
                }

                else
                {
                    if (numbers[i] + result > 10)
                    {
                        numbers[i] = result % 10;
                        leftover = result / 10;
                        numbers.Insert(0, leftover);
                        numbers[i] = leftover;
                    }
                }

            }

            if (numbers.Sum() == 0||numbers[0]==0)
            {
                Console.WriteLine(0);
            }

            else
            {
                Console.WriteLine(string.Join("", numbers));
            }
        }
    }
}
