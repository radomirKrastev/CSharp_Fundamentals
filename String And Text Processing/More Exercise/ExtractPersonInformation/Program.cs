namespace ExtractPersonInformation
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                var name = string.Empty;
                int? age = null;
                var text = Console.ReadLine().Split();
                var foundAge = false;
                var foundName = false;


                foreach (var str in text)
                {
                    if (str.StartsWith('@'))
                    {
                        if (str.EndsWith('|'))
                        {
                            foundName = true;
                            name = str.TrimStart('@');
                            name=name.TrimEnd('|');
                        }

                        else
                        {
                            continue;
                        }
                    }

                    else if (str.StartsWith('#'))
                    {
                        if (str.EndsWith('*'))
                        {
                            foundAge = true;
                            string ageStr = str.TrimStart('#');
                            ageStr = ageStr.TrimEnd('*');
                            age = int.Parse(ageStr);
                        }

                        else
                        {
                            continue;
                        }
                    }

                    else
                    {
                        continue;
                    }
                }

                if (foundAge && foundName)
                {
                    Console.WriteLine($"{name} is {age} years old.");
                }                
            }
        }
    }
}
