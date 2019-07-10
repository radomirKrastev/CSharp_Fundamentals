namespace TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var teamsLimit = int.Parse(Console.ReadLine());
            var command = Console.ReadLine();
            var teamList = new List<Team>();

            while (command != "end of assignment")
            {
                if (command.Contains("->"))
                {
                    var isUserInTeam = false;
                    var data = command.Split("->");
                    var user = data[0];
                    var teamName = data[1];

                    foreach (var team in teamList.Where(x => x.User != null))
                    {
                        if (team.User.Contains(user))
                        {
                            isUserInTeam = true;
                            break;
                        }
                    }

                    if (isUserInTeam == true || teamList.Select(x => x.Creator).Contains(user))
                    {
                        Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    }

                    else if (!teamList.Select(x => x.Name).Contains(teamName))
                    {
                        Console.WriteLine($"Team {teamName} does not exist!");
                    }

                    else
                    {
                        foreach (var team in teamList.Where(x => x.Name == teamName))
                        {
                            team.User += user + ",";
                        }

                    }
                }


                else
                {
                    var data = command.Split("-");
                    var creator = data[0];
                    var teamName = data[1];

                    if (teamList.Select(x => x.Name).Contains(teamName))
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                    }

                    else if (teamList.Select(x => x.Creator).Contains(creator))
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }


                    else
                    {
                        if (!teamList.Select(x => x.User).Contains(creator))
                        {
                            var projectTeam = new Team { Name = teamName, Creator = creator };
                            Console.WriteLine($"Team {teamName} has been created by {creator}!");
                            teamList.Add(projectTeam);
                        }
                    }

                }

                command = Console.ReadLine();
            }

            foreach (var team in teamList
                .Where(x => x.User != null)
                .OrderByDescending(x => x.User.Split(',').Count())
                .ThenBy(x => x.Name))
            {
                var users = team.User.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.Creator);
                Console.WriteLine("-- " + string.Join(Environment.NewLine + "-- ", users.OrderBy(x => x)));
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamList.Where(x => x.User == null).OrderBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
            }

        }
    }

}
