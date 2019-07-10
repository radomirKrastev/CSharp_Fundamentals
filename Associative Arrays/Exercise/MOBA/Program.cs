namespace MOBA
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var playerPositionSkill = new Dictionary<string, Dictionary<string, int>>();
            var playerSkill = new Dictionary<string, int>();
            while(input!="Season end")
            {
                var command = input.Split(new string[] { " vs ", " -> " }, StringSplitOptions.RemoveEmptyEntries);

                if (command.Length == 3)
                {
                    var player = command[0];
                    var position = command[1];
                    var skill = int.Parse(command[2]);
                    var positionSkill = new Dictionary<string, int>();

                    if (!playerPositionSkill.ContainsKey(player))
                    {
                        positionSkill.Add(position, skill);
                        playerPositionSkill.Add(player, positionSkill);
                        playerSkill.Add(player, skill);

                    }

                    else
                    {
                        positionSkill = playerPositionSkill[player];
                        if (!positionSkill.ContainsKey(position))
                        {
                            playerPositionSkill[player].Add(position, skill);
                            playerSkill[player] += skill;
                        }

                        else
                        {
                            if (positionSkill[position] < skill)
                            {
                                playerSkill[player] -= positionSkill[position];
                                playerPositionSkill[player].Remove(position);
                                playerPositionSkill[player].Add(position, skill);
                                playerSkill[player] += skill;
                            }
                        }
                    }
                }

                else
                {
                    var playerOne = command[0];
                    var playerTwo = command[1];

                    if(playerPositionSkill.ContainsKey(playerOne)
                        && playerPositionSkill.ContainsKey(playerTwo))
                    {
                        var playerOnePositions = playerPositionSkill[playerOne].Keys.ToList();
                        var playerTwoPositions = playerPositionSkill[playerTwo].Keys.ToList();
                        bool samePositions = false;
                        var greaterPositionCount = Math.Max(playerOnePositions.Count
                                                      , playerTwoPositions.Count);

                        if(greaterPositionCount== playerOnePositions.Count)
                        {
                            foreach (var position in playerOnePositions)
                            {
                                if (playerTwoPositions.Contains(position))
                                {
                                    samePositions = true;
                                    break;
                                }
                            }
                        }

                        else
                        {
                            foreach (var position in playerTwoPositions)
                            {
                                if (playerOnePositions.Contains(position))
                                {
                                    samePositions = true;
                                    break;
                                }
                            }
                        }

                        if (samePositions == true)
                        {
                            if (playerSkill[playerOne] > playerSkill[playerTwo])
                            {
                                playerSkill.Remove(playerTwo);
                                playerPositionSkill.Remove(playerTwo);
                            }

                            else if(playerSkill[playerTwo]> playerSkill[playerOne])
                            {
                                playerSkill.Remove(playerOne);
                                playerPositionSkill.Remove(playerOne);
                            }
                        }

                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in playerSkill.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} skill");

                foreach (var positionSkill in playerPositionSkill[kvp.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {positionSkill.Key} <::> {positionSkill.Value}");
                }
            }
        }
    }
}
