using System;
using System.Threading;

namespace MindfulnessProgram
{
    public abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration; 

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void SetDuration()
        {
            Console.WriteLine($"\nEnter the duration (in seconds) for the {_name} activity:");
            _duration = int.Parse(Console.ReadLine());
        }

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name} Activity!");
            Console.WriteLine(_description);
            SetDuration();
            Console.WriteLine("Prepare to begin...");
            ShowCountdown(5);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("\nWell done! You have completed the activity.");
            ShowCountdown(5);
            Logger.Log($"{_name} completed. Duration: {_duration} seconds.");
        }

        protected void ShowSpinner(int seconds)
        {
            int iterations = seconds * 4;
            for (int i = 0; i < iterations; i++)
            {
                Console.Write("|");
                Thread.Sleep(250);
                Console.Write("\b");
                Console.Write("/");
                Thread.Sleep(250);
                Console.Write("\b");
                Console.Write("-");
                Thread.Sleep(250);
                Console.Write("\b");
                Console.Write("\\");
                Thread.Sleep(250);
                Console.Write("\b");
            }
            Console.WriteLine();
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
                Console.Write("\b\b");
            }
            Console.WriteLine();
        }

        public abstract void Run();
    }
}
