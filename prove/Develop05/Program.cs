using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = 0;
        List<Goal> goals = new();
        int points = 0;

        do
        {
            userSelection = Menu.MenuOptions(points);

            if (userSelection == 1)
            {
                int goalType = Menu.GoalType();

                Console.Write("What is the name of your goal? ");
                string goalName = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string goalDescription = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int reward = int.Parse(Console.ReadLine());
                
                if (goalType == 1)
                {
                    goals.Add(new SimpleGoal(goalName, goalDescription, reward));
                }
                else if (goalType == 2)
                {
                    goals.Add(new EternalGoal(goalName, goalDescription, reward));
                }
                else if (goalType == 3)
                {
                    Console.Write("How many times does this goal need to be accomplished before completion? ");
                    int totalRequired = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(goalName, goalDescription, reward, totalRequired));
                }
            }
            else if (userSelection == 2)
            {
                int num = 1;

                Console.WriteLine();
                Console.WriteLine("The Goals are: ");
                foreach (Goal g in goals)
                {
                    Console.Write($"{num}. [{g.CheckMarkCheck()}] {g.GetName()} ({g.GetDescription()})");
                    if (g.GetGoalType() == "ChecklistGoal")
                    {
                        Console.WriteLine($" -- Currently completed: {g.GetCompleted()}/{g.GetRequired()}");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    num ++;
                }
            }
            else if (userSelection == 4)
            {
                Console.WriteLine();
                Console.WriteLine("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(fileName);
                
                points = 0;
                goals.Clear();
                int num = 1;

                foreach (string l in lines)
                {
                    if (num != 1)
                    {
                        string [] parts = l.Split("~|/");
                        if (parts[0] == "SimpleGoal")
                        {
                            goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                        }
                        else if (parts[0] == "EternalGoal")
                        {
                            goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        }
                        else if (parts[0] == "ChecklistGoal")
                        {
                            goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                        }
                    }
                    else
                    {
                        points = int.Parse(l);
                        num ++;
                    }
                }
            }
            else if (userSelection == 3)
            {
                Console.WriteLine();
                Console.WriteLine("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(points);
                    foreach (Goal g in goals)
                    {
                        outputFile.WriteLine(g.SaveGoal());
                    }
                }
            }
            else if (userSelection == 5)
            {
                int num = 1;

                Console.WriteLine();
                Console.WriteLine("The Goals are: ");
                foreach (Goal g in goals)
                {
                    Console.WriteLine($"{num}. {g.GetName()}");
                    num ++;
                }

                Console.Write("Which goal did you accomplish? ");
                num = int.Parse(Console.ReadLine()) - 1;
                int reward = goals[num].CalculateReward();

                Console.WriteLine();
                Console.WriteLine($"Congratulations! You have earned {reward} points!");
                points = points + reward;
                Console.WriteLine($"You now have {points} points.");
            }
        } while (userSelection != 6);
    }
}