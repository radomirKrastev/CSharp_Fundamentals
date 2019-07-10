namespace ListOfProducts
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        static void Main()
        {
            int countOfProducts = int.Parse(Console.ReadLine());

            List<string> productsList = new List<string>();

            for (int i = 0; i < countOfProducts; i++)
            {
                string product = Console.ReadLine();
                productsList.Add(product);
            }

            productsList.Sort();

            for (int i = 1; i <= productsList.Count; i++)
            {
                Console.WriteLine(i+"."+productsList[i-1]);
            }

        }
    }
}
