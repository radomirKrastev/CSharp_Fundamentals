namespace NetherRealms
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var demons = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            var healthInvalidSymbols = @"[\/\d+\-*\/.]";
            var demonBook = new Dictionary<string, string>();

            foreach (var demon in demons)
            {
                var health = Regex.Replace(demon, healthInvalidSymbols, string.Empty);
                var healthPoints = 0;

                foreach (var c in health)
                {
                    healthPoints += (int)(c);
                }

                var additionalCalculations = Regex.Matches(demon, @"[*\/]");
                var negativeNumbers = Regex.Matches(demon, @"[-]\d+[\.]\d+|[-]\d+");
                //var demonsNoNegative = Regex.Replace(demon, @"[-]\d[.]\d+|[-]\d+", string.Empty); 
                var demonsNoNegative = Regex.Replace(demon, @"[-]\d+[\.]\d+|[-]\d+", string.Empty); 
                //var positiveNumbers = Regex.Matches(demonsNoNegative, @"(?<![-0-9.])\d+[.\d]*");
                var positiveNumbers = Regex.Matches(demonsNoNegative, @"[+]?\d+[\.]*\d+|[+]?\d+");

                var negativeNumbersTotal = 0.0m;

                foreach (var number in negativeNumbers)
                {
                    negativeNumbersTotal += decimal.Parse(number.ToString());
                }

                var positiveNumbersTotal = 0.0m;

                foreach (var number in positiveNumbers)
                {
                    positiveNumbersTotal += decimal.Parse(number.ToString());
                }

                var damage = positiveNumbersTotal + negativeNumbersTotal;

                if (damage != 0)
                {
                    foreach (var calculation in additionalCalculations)
                    {
                        if (calculation.ToString().Equals("*"))
                        {
                            damage *= 2;
                        }

                        else
                        {
                            damage /= 2;
                        }
                    }
                }

                var data = $"{healthPoints} health, {damage:F2} damage";
                demonBook.Add(demon, data);
            }

            foreach (var demon in demonBook.OrderBy(x => x.Key))
            {
                Console.WriteLine(demon.Key + " - " + demon.Value);
            }
        }
    }
}
