namespace StringExplosion
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var power = 0;
            var newText = string.Empty;

            foreach (var c in text)
            {
                if(c.ToString().All(x=>char.IsDigit(x)) && newText[newText.Length-1]=='>')
                {
                    power+=int.Parse(c.ToString());
                    power--;
                }

                else if (power == 0 ||c=='>' )
                {
                    newText += c;
                }

                else if (power!=0 && c!='>')
                {
                    power--;
                }                                                
            }

            Console.WriteLine(newText);                                   
        }
    }
}
