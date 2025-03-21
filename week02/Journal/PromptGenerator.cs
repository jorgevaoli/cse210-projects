using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What challenge did I face today and how did I handle it?",
        "What was the funniest or most unexpected moment of my day?",
        "What are three things I am grateful for today?",
        "If I could send a message to my future self, what would I say?",
        "What was the strongest emotion I felt today?",
        "What small thing made today special?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
