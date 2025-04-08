using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessProgram
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity(string name, string description) : base(name, description) { }

        public override void Run()
        {
            DisplayStartingMessage();
            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine($"\nListing prompt: {prompt}");
            Console.WriteLine("Get ready to list items...");
            ShowCountdown(5);

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            List<string> items = new List<string>();
            Console.WriteLine("Start listing items. Press Enter after each item:");
            
            while (DateTime.Now < endTime)
            {
                Console.Write("Item: ");
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                {
                    items.Add(item);
                }
            }

            Console.WriteLine($"\nYou listed {items.Count} items.");
            DisplayEndingMessage();
        }
    }
}
