namespace Songs
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var songsCount = int.Parse(Console.ReadLine());
            var songList = new List<Song>();
            for (int i = 0; i < songsCount; i++)
            {
                var songInfo = Console.ReadLine().Split('_').ToList();
                var type = songInfo[0];
                var name = songInfo[1];
                var time = songInfo[2];
                Song song = new Song
                {
                    TypeList=type,
                    Name=name,
                    Duration=time
                };

                songList.Add(song);
            }

            var playlist = Console.ReadLine();
            if (playlist == "all")
            {
                foreach (var song in songList)
                {
                    Console.WriteLine(song.Name);
                }
            }

            else
            {
                foreach (var song in songList.Where(x => x.TypeList == playlist))
                {
                    Console.WriteLine(song.Name);
                }
            }
            
        }
    }
}
