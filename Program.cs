// Creativity - Exceeds Core Requirements:
// 1. Added a 4th activity: GratitudeActivity. It asks the user to list things they are grateful for.
// 2. Added an Activity Log: Every time an activity finishes, it saves the activity name and date to "mindfulness_log.txt"
//    and shows the total number of activities completed in this session.
// 3. Added a "How many activities have you done?" counter on the menu.

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int totalActivitiesCompleted = 0;
        string choice = "";

        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start gratitude activity");
            Console.WriteLine("  5. Quit");
            Console.WriteLine($"Activities completed this session: {totalActivitiesCompleted}");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                totalActivitiesCompleted++;
                LogActivity("Breathing Activity");
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                totalActivitiesCompleted++;
                LogActivity("Reflecting Activity");
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                totalActivitiesCompleted++;
                LogActivity("Listing Activity");
            }
            else if (choice == "4")
            {
                GratitudeActivity gratitude = new GratitudeActivity();
                gratitude.Run();
                totalActivitiesCompleted++;
                LogActivity("Gratitude Activity");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye! Stay mindful.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }
        }
    }

    static void LogActivity(string activityName)
    {
        string logEntry = $"{DateTime.Now} - Completed: {activityName}";
        File.AppendAllText("mindfulness_log.txt", logEntry + Environment.NewLine);
    }
}
