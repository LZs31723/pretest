using Microsoft.EntityFrameworkCore;
using WebApplication8.Data;
using WebApplication8.DTO;

namespace WebApplication8.Service;

public class ServiceCourse : IServiceCourse
{
    private readonly AppDbContext _context;

    public ServiceCourse(AppDbContext context)
    {
        _context = context;
    }


    public async Task<List<CourseSummaryDTO>> GetPatientsAsync(int? courseId)
    {
        var query = _context.Courses.AsQueryable();

        if (courseId.HasValue)
        {
            query = query.Where(e => e.Id == courseId.Value);
        }
        return await query.
        Select(c => new CourseSummaryDTO
        {
            CourseId = c.Id,
            Title = c.Title,
            LessonCount = c.Lessons.Count(),
            StudentsCount = c.Enrollments.Count(),
            AverageRating = c.Reviews.Any() ? c.Reviews.Average(r => r.Rating) : 0,
            CertificatesIssued = c.Certificates.Count()
        }).ToListAsync();
    }

}
