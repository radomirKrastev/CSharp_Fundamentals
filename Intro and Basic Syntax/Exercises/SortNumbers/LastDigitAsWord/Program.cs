
namespace LastDigitAsWord
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int dataInput = int.Parse(Console.ReadLine());
            string dataAsString = dataInput.ToString();

            if (dataAsString[dataAsString.Length - 1] == '1')
            {
                Console.WriteLine("one");
            }
            else if (dataAsString[dataAsString.Length - 1] == '2')
            {
                Console.WriteLine("two");
            }
            else if (dataAsString[dataAsString.Length - 1] == '3')
            {
                Console.WriteLine("three");
            }
            else if (dataAsString[dataAsString.Length - 1] == '4')
            {
                Console.WriteLine("four");
            }
            else if (dataAsString[dataAsString.Length - 1] == '5')
            {
                Console.WriteLine("five");
            }
            else if (dataAsString[dataAsString.Length - 1] == '6')
            {
                Console.WriteLine("six");
            }
            else if (dataAsString[dataAsString.Length - 1] == '7')
            {
                Console.WriteLine("seven");
            }
            else if (dataAsString[dataAsString.Length - 1] == '8')
            {
                Console.WriteLine("eight");
            }
            else if (dataAsString[dataAsString.Length - 1] == '0')
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("nine");
            }
            
        }

        
    }
}
