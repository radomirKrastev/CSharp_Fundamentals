namespace JournalQuest
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var quests = Console.ReadLine().Split(", ").ToList();
            var command = Console.ReadLine().Split(" - ");

            while (command[0]!= "Retire!")
            {
                if (command[0] == "Start")
                {
                    var quest = command[1];
                    if (!quests.Contains(quest))
                    {
                        quests.Add(quest);
                    }
                }

                else if (command[0] == "Complete")
                {
                    var quest = command[1];
                    if (quest.Contains(quest))
                    {
                        quests.Remove(quest);
                    }
                }

                else if (command[0]=="Side Quest")
                {
                    var quest = command[1].Split(':')[0];
                    var sideQuest = command[1].Split(':')[1];

                    if (quests.Contains(quest) && !quests.Contains(sideQuest))
                    {
                        var index = quests.IndexOf(quest);

                        if (index == quests.Count - 1)
                        {
                            quests.Add(sideQuest);
                        }

                        else
                        {
                            quests.Insert(index + 1, sideQuest);
                        }
                    }
                }

                else
                {
                    var quest = command[1];
                    if (quests.Contains(quest))
                    {
                        quests.Remove(quest);
                        quests.Add(quest);
                    }
                }

                command = Console.ReadLine().Split(" - ");
            }

            Console.WriteLine(string.Join(", ", quests));

        }
    }
}
