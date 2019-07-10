namespace BalancedBrackets
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int linesOfInputCount = int.Parse(Console.ReadLine());

            string bracketStatus = null;
            bool areBracketsBalanced = true;
            int countOfBrackets = 0;
            for (int i = 1; i <= linesOfInputCount; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if ((bracketStatus == null || bracketStatus == "closed") && areBracketsBalanced == true)
                    {
                        bracketStatus = "opened";
                        countOfBrackets++;
                    }
                    else
                    {
                        areBracketsBalanced = false;
                    }
                }
                else if (input == ")")
                {
                    if ((bracketStatus == "opened" || bracketStatus == null) && areBracketsBalanced == true)
                    {
                        bracketStatus = "closed";
                        countOfBrackets++;
                    }
                    else
                    {
                        areBracketsBalanced = false;
                    }
                }
            }

            if (countOfBrackets % 2 !=0)
            {
                areBracketsBalanced = false;
            }

            if (areBracketsBalanced == true)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
            
        }
    }
}
