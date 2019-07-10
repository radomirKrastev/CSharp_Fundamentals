namespace SoftUniCoursePlanning
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            List<string> courseElements = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            string command = Console.ReadLine();
            while (command != "course start")
            {
                List<string> action = command.Split(":").ToList();

                courseElements = ChangeProgram(courseElements, action);
                command = Console.ReadLine();
            }

            for (int i = 0; i < courseElements.Count; i++)
            {
                int counter = i + 1;
                Console.Write(counter+"."+ courseElements[i]);
                Console.Write(Environment.NewLine);
            }
        }

        public static List<string> ChangeProgram(List<string> courseElements, List<string> action)
        {
            switch (action[0])
            {
                case "Add":
                    {
                        if (!courseElements.Contains(action[1]))
                        {
                            courseElements.Add(action[1]);
                        }
                    }
                    break;
                case "Insert":
                    {
                        if (!courseElements.Contains(action[1]))
                        {
                            courseElements.Insert(int.Parse(action[2]), action[1]);
                        }
                    }
                    break;
                case "Remove": //needs adjustment !
                    {
                        if (courseElements.Contains(action[1])&&courseElements.Contains(action[1]+"-Exercise"))
                        {
                            courseElements.Remove(action[1]);
                            courseElements.Remove(action[1]+"-Exercise");
                        }
                        else if (courseElements.Contains(action[1]))
                        {
                            courseElements.Remove(action[1]);
                        }
                    }
                    break;
                case "Swap": 
                    {
                        if (courseElements.Contains(action[1]) && courseElements.Contains(action[2]))
                        {
                            int indexFirstTheme = courseElements.IndexOf(action[1]);
                            int indexSecondTheme = courseElements.IndexOf(action[2]);

                            courseElements[indexFirstTheme] = action[2];
                            courseElements[indexSecondTheme] = action[1];

                            if (courseElements.Contains(action[1]+"-Exercise"))
                            {
                                courseElements.RemoveAt(indexFirstTheme + 1);
                                if(indexSecondTheme == courseElements.Count)
                                {
                                    courseElements.Add(action[1] + "-Exercise");
                                }
                                else
                                {
                                    courseElements.Insert(indexSecondTheme + 1, action[1] + "-Exercise");
                                }

                            }
                            if (courseElements.Contains(action[2] + "-Exercise"))
                            {
                                courseElements.RemoveAt(indexSecondTheme + 1);
                                if (indexSecondTheme == courseElements.Count)
                                {
                                    courseElements.Add(action[2] + "-Exercise");
                                }
                                else
                                {
                                    courseElements.Insert(indexFirstTheme + 1, action[2] + "-Exercise");
                                }
                                
                            }
                        }
                    }
                    break;
                case "Exercise":
                    {
                        if (courseElements.Contains(action[1]) && !courseElements.Contains(action[1] + "-Exercise"))
                        {
                            int themeIndex = -1;
                            for (int i = 0; i < courseElements.Count; i++)
                            {
                                if (courseElements[i] == action[1])
                                {
                                    themeIndex = i;
                                    break;
                                }
                            }

                            courseElements.Insert(themeIndex + 1, action[1] + "-Exercise");
                        }
                        else if (!courseElements.Contains(action[1]))
                        {
                            courseElements.Add(action[1]);
                            courseElements.Add(action[1] + "-Exercise");
                        }

                    }
                    break;
            }
            return courseElements;
        }
    }
}
