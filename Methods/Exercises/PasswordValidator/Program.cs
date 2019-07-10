
namespace PasswordValidator
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string passwordInput = Console.ReadLine();
            PrintsCorrectPasswordOrNot(passwordInput);
        }

        public static void PrintsCorrectPasswordOrNot (string password)
        {
            if(CheckCharactersCount(password) == true)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            
            if(CheckForWrongCharacters(password) == true)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (CheckDigitsCount(password) == true)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if(CheckCharactersCount(password) == false && CheckForWrongCharacters(password) == false
                & CheckDigitsCount(password) == false)
            {
                Console.WriteLine("Password is valid");
            }
                
        }

        public static bool CheckCharactersCount (string password)
        {
            bool wrongPassword = false;

            if (password.Length < 6 || password.Length > 10)
            {
                wrongPassword = true;
            }

            return wrongPassword;
        }

        public static bool CheckForWrongCharacters(string password)
        {
            bool wrongPassword = false;

            foreach (var c in password)
            {
                if (!char.IsLetterOrDigit(c)) 
                {
                    wrongPassword = true;
                    
                }
            }
            return wrongPassword;
        }

        public static bool CheckDigitsCount(string password)
        {
            int digitsCount = 0;
            bool wrongPassword = false;

            foreach (var c in password)
            {
                if (char.IsDigit(c))
                {
                    digitsCount++;
                }
                
            }

            if (digitsCount < 2)
            {
                wrongPassword = true;
            }

            return wrongPassword;
        }

    }
}
