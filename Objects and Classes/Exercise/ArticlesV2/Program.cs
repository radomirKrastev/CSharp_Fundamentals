namespace ArticlesV2
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var articlesCount = int.Parse(Console.ReadLine());
            var articlesList = new List<Article>();
            for (int i = 0; i < articlesCount; i++)
            {
                var data = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                var title = data[0];
                var content = data[1];
                var author = data[2];

                var article = new Article(title, content, author)
                {
                    Title = title,
                    Content = content,
                    Author = author
                };

                articlesList.Add(article);
            }

            var output = Console.ReadLine();
            if (output == "title")
            {
                foreach (var article in articlesList.OrderBy(x=>x.Title))
                {
                    Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                }
            }

            else if (output == "content")
            {
                foreach (var article in articlesList.OrderBy(x => x.Content))
                {
                    Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                }
            }

            else
            {
                foreach (var article in articlesList.OrderBy(x => x.Author))
                {
                    Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
                }
            }
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }


        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void RenameTitle(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {

            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }

}
