namespace AnimalSanctuary
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var linesOfInput = int.Parse(Console.ReadLine());
            var pattern = @"^n:(?<name>[^\;]+);t:(?<type>[^\;]+);c--(?<country>[A-Za-z\s]+)$";
            var totalKilograms = 0;

            for (int i = 0; i < linesOfInput; i++)
            {
                var message = Console.ReadLine();

                if (Regex.IsMatch(message, pattern))
                {
                    var decryptedMessage = Regex.Match(message, pattern);
                    var nameRaw = decryptedMessage.Groups["name"].Value;
                    var typeRaw = decryptedMessage.Groups["type"].Value;
                    var country = decryptedMessage.Groups["country"].Value;

                    var nameOnly = Regex.Replace(nameRaw, @"[^A-Za-z\s\t]", string.Empty);
                    var typeOnly = Regex.Replace(typeRaw, @"[^A-Za-z\s\t]+", string.Empty);
                    var digitsOfKgInName = Regex.Replace(nameRaw, @"[^\d]", string.Empty).ToString();
                    var digitsOfKgInType = Regex.Replace(typeRaw, @"[^\d]", string.Empty).ToString();
                    var totalDigitsOfKg = digitsOfKgInName + digitsOfKgInType;
                    var animalKilograms = 0;

                    foreach (var digit in totalDigitsOfKg)
                    {
                        animalKilograms += int.Parse(digit.ToString());
                    }

                    totalKilograms += animalKilograms;

                    Console.WriteLine($"{nameOnly} is a {typeOnly} from {country}");
                }
            }

            Console.WriteLine($"Total weight of animals: {totalKilograms}KG");
        }
    }
}
