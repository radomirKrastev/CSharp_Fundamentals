namespace SongEncryption
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var data = input.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                var artist = data[0];
                var song = data[1];

                var artistPattern = @"^[A-Z][a-z\'\ ]+$";
                var validArtist = Regex.IsMatch(artist, artistPattern);
                var songPattern = @"^[A-Z\ ]+$";
                var validSong = Regex.IsMatch(song, songPattern);

                if (validArtist && validSong)
                {
                    var key = artist.Length;
                    var encryptedMessage = string.Empty;

                    foreach (var c in input)
                    {
                        char symbol = c;

                        if (c==' '|| c == '\'')
                        {
                            encryptedMessage += symbol.ToString();
                            continue;
                        }

                        if (c == ':')
                        {
                            symbol = '@';
                        }

                        else
                        {
                            for (int i = 1; i <= key; i++)
                            {
                                if (char.IsLower(c))
                                {
                                    if (symbol == 'z')
                                    {
                                        symbol = 'a';
                                    }

                                    else
                                    {
                                        symbol += (char)1;
                                    }
                                }

                                else
                                {
                                    if (symbol == 'Z')
                                    {
                                        symbol = 'A';
                                    }

                                    else
                                    {
                                        symbol += (char)1;
                                    }
                                }
                            }
                        }                        

                        encryptedMessage += symbol.ToString();
                    }

                    Console.WriteLine($"Successful encryption: {encryptedMessage}");
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
