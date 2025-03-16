using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            
            Console.WriteLine($"You have {Goals.GetTotalPoints()} points");
            Console.WriteLine("\nMenu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Handle Goal Creation
                    Console.WriteLine("\nThe types of Goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    Console.Write("\nWhat is the name of your goal? ");
                    string name = Console.ReadLine();
                    
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    
                    Console.Write("What is the amount of points for this goal? ");
                    if (!int.TryParse(Console.ReadLine(), out int points))
                    {
                        Console.WriteLine("Invalid points. Setting to 50 by default.");
                        points = 50;
                    }

                    switch (goalType)
                    {
                        case "1":
                            Goals basic = new Basic(name, description, points);
                            break;
                        case "2":
                            Goals eternal = new Eternal(name, description, points);
                            break;
                        case "3":
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            if (!int.TryParse(Console.ReadLine(), out int targetCount))
                            {
                                targetCount = 3; //* if the user doesnt put anything in
                            }
                            
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            if (!int.TryParse(Console.ReadLine(), out int bonusPoints))
                            {
                                bonusPoints = points * 2; // Default bonus
                            }
                            
                            Goals checklist = new Checklist(name, description, points, bonusPoints, targetCount);
                            break;
                        default:
                            Console.WriteLine("Invalid goal type. Creating a Simple Goal by default.");
                            Goals defaultGoal = new Basic(name, description, points);
                            break;
                    }
                    break;
                    
                case "2":
                    Console.Clear();
                    Console.WriteLine("The goals are:");
                    Goals.PrintAllGoals();
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    break;
                    
                case "3":
                    Console.Write("What is the filename for the goal file? ");
                    string saveFileName = Console.ReadLine();
                    Goals.SaveToFile(saveFileName);
                    Console.WriteLine($"Goals saved to {saveFileName}");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    break;
                    
                case "4":
                    Console.Write("What is the filename for the goal file? ");
                    string loadFileName = Console.ReadLine();
                    Goals.LoadFromFile(loadFileName);
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    break;
                    
                case "5":
                    // Record event for a goal
                    Console.Clear();
                    Console.WriteLine("The goals are:");
                    List<Goals> incompleteGoals = Goals.GetIncompleteGoals();
                    
                    if (incompleteGoals.Count == 0)
                    {
                        Console.WriteLine("You have no goals to record progress for.");
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    }
                    
                    // Display goals with numbers
                    for (int i = 0; i < incompleteGoals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {incompleteGoals[i].Getgoal()}");
                    }
                    
                    Console.Write("\nWhich goal did you accomplish? ");
                    if (int.TryParse(Console.ReadLine(), out int goalIndex) && 
                        goalIndex >= 1 && goalIndex <= incompleteGoals.Count)
                    {
                        // Call RecordEvent on the selected goal
                        incompleteGoals[goalIndex - 1].RecordEvent();
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection. No event recorded.");
                    }
                    
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    break;
                    
                case "6":
                    Console.WriteLine("Thank you for using the Eternal Quest program!");
                    return;
                    
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}