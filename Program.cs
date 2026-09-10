Console.WriteLine("Study Tracker");

bool running = true;

List<StudySession> studySessions = new List<StudySession>();

while (running)
{
    ShowMenu();
    string? menuChoice = Console.ReadLine();

    if (menuChoice == "1")
    {
       StartStudySession(studySessions); 
    }
    else if (menuChoice == "2")
    {
       ViewHistory(studySessions);  
    }
    else if (menuChoice == "3")
    {
        running = false;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
    
    void ShowMenu()
    {
        Console.WriteLine("1. Start study session");
        Console.WriteLine("2. View history");
        Console.WriteLine("3. Exit");
    }
    
    void ViewHistory(List<StudySession> sessions)
    {
        if(sessions.Count == 0)
        {
            Console.WriteLine("No study sessions found");
        }
        else
        {
            foreach (StudySession session in sessions)
            {
                Console.WriteLine($"Subject: {session.Subject}");
                Console.WriteLine($"Started at: {session.StartTime}");
                Console.WriteLine($"Finished at: {session.EndTime}");
                if (session.EndTime.HasValue)
                {
                    TimeSpan duration = session.EndTime.Value - session.StartTime;

                    Console.WriteLine($"Duration: {duration.Hours}h {duration.Minutes}m {duration.Seconds}s");
            
                }

                if (!string.IsNullOrWhiteSpace(session.Note))
                {
                    Console.WriteLine($"Note: {session.Note}");
                   
                }

                Console.WriteLine();
                 
            }
        }
    }

    void StartStudySession(List<StudySession> sessions)
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
        
        StudySession session = new StudySession
        {
            Subject = subject,
            StartTime = DateTime.Now
        };
        Console.WriteLine("Session started.");  

        Console.WriteLine("Press Enter to stop the session");
        Console.ReadLine();
        
        session.EndTime = DateTime.Now;

        TimeSpan duration = session.EndTime.Value - session.StartTime;

        Console.WriteLine("Add a note (optional): ");
        session.Note = Console.ReadLine();

        sessions.Add(session);

        Console.WriteLine($"You studied {session.Subject} for {duration.Hours}h {duration.Minutes}m {duration.Seconds}s");
   

    }

     
}


