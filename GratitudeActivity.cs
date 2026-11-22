using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts;

    public GratitudeActivity() : base("Gratitude Activity",
        "This activity will help you focus on gratitude. You will list things you are grateful for and feel more peace and joy.")
    {
        _prompts = new List<string>
        {
            "What blessing from today are you grateful for?",
            "Who is someone God placed in your life that you are grateful for?",
            "What is one small thing that brought you joy this week?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("Take a moment to think, then type your answer and press enter.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        Console.Write("> ");
        string answer = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Thank you for sharing. Remember this gratitude today.");
        ShowSpinner(3);

        DisplayEndingMessage();
    }
}
