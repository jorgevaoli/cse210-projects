using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program Menu:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Choose an option: ");
                
                string choice = Console.ReadLine();
                Activity activity = null;
                
                switch (choice)
                {
                    case "1":
                        activity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                        break;
                    case "2":
                        activity = new ReflectingActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                        break;
                    case "3":
                        activity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                        break;
                    case "4":
                        running = false;
                        continue;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        Console.ReadLine();
                        continue;
                }
                
                activity.Run();
                Console.WriteLine("\nPress Enter to return to the main menu...");
                Console.ReadLine();
            }
        }
    }
}
