namespace ActivationKeys
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var data = Console.ReadLine().Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
            var validKeyPattern = @"^[a-zA-Z0-9]{25}$|^[a-zA-Z0-9]{16}$";
            var keys = new List<string>();

            foreach (var dataKey in data)
            {
                if (Regex.IsMatch(dataKey, validKeyPattern))
                {
                    var validKey = string.Empty;

                    if (dataKey.Length == 25)
                    {
                        var key = dataKey;
                        var length = 5;
                        validKey = GetKeyWithDashes(key, validKey, length);
                        validKey = ModifyFurther(validKey);
                    }

                    else if (dataKey.Length == 16)
                    {
                        var key = dataKey;
                        var length = 4;
                        validKey = GetKeyWithDashes(key, validKey, length);
                        validKey = ModifyFurther(validKey);
                    }

                    if (validKey.Length > 0)
                    {
                        keys.Add(validKey);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", keys));
        }

        public static string GetKeyWithDashes(string key,string validKey, int length)
        {
            while (key.Length > 0)
            {
                validKey += key.Substring(0, length)+"-";
                key = key.Remove(0, length);
            }

            return validKey.TrimEnd('-');
        }

        public static string ModifyFurther (string validKey)
        {
            var modifiedKey = string.Empty;

            foreach (var c in validKey)
            {
                if (char.IsDigit(c))
                {
                    var digit = (9 - int.Parse(c.ToString())).ToString();
                    modifiedKey += digit;
                }

                else
                {
                    var symbol = char.ToUpper(c);
                    modifiedKey += symbol;
                }
            }

            return modifiedKey;
        }
    }
}
