namespace HTML
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var articleTitle = Console.ReadLine();
            Console.WriteLine("<h1>");
            Console.WriteLine("    "+articleTitle);
            Console.WriteLine("</h1>");

            var articleContent = Console.ReadLine();
            Console.WriteLine("<article>");
            Console.WriteLine("    " + articleContent);
            Console.WriteLine("</article>");

            var comment = Console.ReadLine();

            while(comment!="end of comments")
            {
                Console.WriteLine("<div>");
                Console.WriteLine("    " + comment);
                Console.WriteLine("</div>");
                comment = Console.ReadLine();
            }
        }
    }
}
