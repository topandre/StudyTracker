public class StudySession
{
    public required string Subject { get; set; }
    public required DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public TimeSpan? Duration
    {
        get
        {
            if (EndTime.HasValue)
            {
                return EndTime.Value - StartTime;
            }

            return null;
        }
    }
    public string? Note { get; set; }
    
}