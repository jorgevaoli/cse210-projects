using System;
using System.Threading;

namespace MindfulnessProgram
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description) : base(name, description) { }

        public override void Run()
        {
            DisplayStartingMessage();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("Breathe in... ");
                ShowBreathingAnimation(3);
                Console.WriteLine();

                Console.Write("Breathe out... ");
                ShowCountdown(5);
                Console.WriteLine();
            }

            DisplayEndingMessage();
        }

        private void ShowBreathingAnimation(int seconds)
        {
            int totalIterations = seconds * 5;
            for (int i = 1; i <= totalIterations; i++)
            {
                int delay = (int)(100 + (400 * ((double)i / totalIterations)));
                Console.Write("*");
                Thread.Sleep(delay);
            }
        }
    }
}
