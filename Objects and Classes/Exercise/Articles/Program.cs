namespace Articles
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var data = Console.ReadLine().Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries);
            var title = data[0];
            var content = data[1];
            var author = data[2];

            var article = new Article(title, content, author)
            {
                Title = title,
                Content = content,
                Author = author
            };

            var commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                var command = Console.ReadLine().Split(new string [] {":  ", ": ", ":" },StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Edit")
                {
                    var newContent = command[1];
                    article.Edit(newContent);
                }

                else if (command[0] == "ChangeAuthor")
                {
                    var newAuthor = command[1];
                    article.ChangeAuthor(newAuthor);
                }
                
                else
                {
                    var newTitle = command[1];
                    article.RenameTitle(newTitle);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }

}
