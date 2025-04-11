using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string input = "";

        while (input != "6")
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string type = Console.ReadLine();

                Console.Write("Enter your goal name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your goal description: ");
                string description = Console.ReadLine();
                Console.Write("Enter point value: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                    manager.AddGoal(new SimpleGoal(name, description, points));
                else if (type == "2")
                    manager.AddGoal(new EternalGoal(name, description, points));
                else if (type == "3")
                {
                    Console.Write("How many times does it need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                }
            }
            else if (input == "2")
            {
                manager.DisplayGoals();
                manager.DisplayScore();
            }
            else if (input == "3")
            {
                Console.Write("Enter file name to save: ");
                string filename = Console.ReadLine();
                manager.SaveGoals(filename);
            }
            else if (input == "4")
            {
                Console.Write("Enter file name to load: ");
                string filename = Console.ReadLine();
                manager.LoadGoals(filename);
            }
            else if (input == "5")
            {
                manager.DisplayGoals();
                Console.Write("Which goal did you accomplish? ");
                int index = int.Parse(Console.ReadLine()) - 1;
                manager.RecordEvent(index);
            }
        }
    }
}
