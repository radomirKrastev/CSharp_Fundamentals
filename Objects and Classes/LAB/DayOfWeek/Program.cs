namespace DayOfWeek
{
    using System;
    using System.Globalization;
    public class Program
    {
        public static void Main()
        {
            var dateAsText = Console.ReadLine();

            DateTime date = DateTime.ParseExact(dateAsText,"dd-MM-yyyy", CultureInfo.InstalledUICulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
