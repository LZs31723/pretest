namespace WebApplication8.DTO;

public class CourseSummaryDTO
{
    public int CourseId { get; set; }
    public string Title { get; set; } = null !;
    public int LessonCount { get; set; }
    public int StudentsCount { get; set; }
    public double AverageRating { get; set; }
    public int CertificatesIssued { get; set; }
    
    
    
}