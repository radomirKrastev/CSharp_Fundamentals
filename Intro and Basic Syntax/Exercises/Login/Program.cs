
namespace Login
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string username = Console.ReadLine();
            string result = null;
            int incorrectLogInAttempts = 0;

            while (result != "blocked" && result != "success")
            {
                string inputedPassword = Console.ReadLine();
                result = GetLogInAttemptResult(username, incorrectLogInAttempts, inputedPassword);
                
                if (result == "fail")
                {
                    incorrectLogInAttempts++;
                    if (incorrectLogInAttempts == 4)
                    {
                        result = "blocked";
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

            if (result == "blocked")
            {
                Console.WriteLine("User " + username +" blocked!");
            }
            else
            {
                Console.WriteLine("User " + username + " logged in.");
            }
        }
        
        public static string GetLogInAttemptResult(string username,int countOfAttempts, string inputedPassword)
        {
            int incorrectLogInAttempts = countOfAttempts;
            string result = null;
            string validPassword = GetReversedUsername(username).ToString();

            
            if (inputedPassword == validPassword)
            {
                result = "success";
            }

            else
            {
                incorrectLogInAttempts++;
                result = "fail";
            }

            return result;
        }

        public static string GetReversedUsername(string username)
        {
            string[] reversedUsernameArray = new string[username.Length];
            for (int i = 0; i < username.Length; i++)
            {
                reversedUsernameArray[i] = username[i].ToString();
            }
            Array.Reverse(reversedUsernameArray);

            string reversedUsername = "";

            for (int i = 0; i < reversedUsernameArray.Length; i++)
            {
                 reversedUsername += reversedUsernameArray[i];
            }

            return reversedUsername;
        
        }
    }
}
