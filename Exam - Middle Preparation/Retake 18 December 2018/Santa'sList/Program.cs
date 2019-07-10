namespace Santa_sList
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var noisyKids = Console.ReadLine().Split('&').ToList();

            var command = Console.ReadLine().Split();

            while (command[0] != "Finished!")
            {
                if (command[0] == "Bad")
                {
                    var kid = command[1];
                    if (!noisyKids.Contains(kid))
                    {
                        noisyKids.Insert(0, kid);
                    }                    
                }

                else if (command[0] == "Good")
                {
                    var kid = command[1];
                    if (noisyKids.Contains(kid))
                    {
                        noisyKids.Remove(kid);
                    }
                }

                else if (command[0] == "Rename")
                {
                    var oldName = command[1];
                    var newName = command[2];
                    if (noisyKids.Contains(oldName))
                    {
                        var index = noisyKids.IndexOf(oldName);
                        noisyKids[index] = newName;
                    }
                }

                else
                {
                    var kid = command[1];
                    if (noisyKids.Contains(kid))
                    {
                        noisyKids.Remove(kid);
                        noisyKids.Add(kid);
                    }
                }                
                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ", noisyKids));
        }
    }
}
