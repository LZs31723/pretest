using WebApplication8.DTO;

namespace WebApplication8.Service;

public interface IServiceCourse
{
    Task<List<CourseSummaryDTO>> GetPatientsAsync(int? courseId);
}