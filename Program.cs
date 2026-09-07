Console.WriteLine("Study Tracker");

bool running = true;

while (running)
{
    Console.WriteLine("1. Start study session");
    Console.WriteLine("2. Exit");
    string? menuChoice = Console.ReadLine();

    if (menuChoice == "1")
    {
        
        Console.WriteLine("Which subject do you want to study?");
        string? subject = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(subject))
        {
            Console.WriteLine("Subject is empty. Please try again.");
            Console.WriteLine("Which subject do you want to study?");
            subject = Console.ReadLine();
        }
            

        Console.WriteLine("Press Enter to start the session");
        Console.ReadLine();
        DateTime startTime = DateTime.Now;
        Console.WriteLine("Session started.");  

        Console.WriteLine("Press Enter to stop the session");
        Console.ReadLine();
        DateTime endTime = DateTime.Now;
        TimeSpan duration = endTime - startTime;

        Console.WriteLine($"You studied {subject} for {duration.Hours}h {duration.Minutes}m {duration.Seconds}s");
    }
    else if (menuChoice == "2")
    {
        running = false;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
    
    
   

}


