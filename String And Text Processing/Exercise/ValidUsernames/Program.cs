namespace ValidUsernames
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var usernames = Console.ReadLine().Split(", ");

            foreach (var user in usernames)
            {
                
                if (user.Length < 3 || user.Length > 16)
                {
                    continue;
                }

                bool validsymbols = true;
                foreach (var c in user)
                {
                    if(!char.IsLetterOrDigit(c) && c!='_' && c != '-')
                    {
                        validsymbols = false;
                        break;
                    }
                }

                if (!validsymbols)
                {
                    continue;
                }

                Console.WriteLine(user);
            }
        }
    }
}
