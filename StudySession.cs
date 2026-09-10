public class StudySession
{
    public required string Subject { get; set; }
    public required DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? Note { get; set; }
}