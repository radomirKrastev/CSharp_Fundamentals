namespace DecryptMessage
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int keyValue = int.Parse(Console.ReadLine());
            int countOfLetters = int.Parse(Console.ReadLine());

            string messageDecrypted = null;

            for (int i = 1; i <= countOfLetters; i++)
            {
                char letterGiven = char.Parse(Console.ReadLine());
                char letterDecrypted = (char)(letterGiven + keyValue);
                messageDecrypted += letterDecrypted;
            }
            Console.WriteLine(messageDecrypted);
        }
    }
}
