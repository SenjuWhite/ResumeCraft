using ResumeCraft_API.Models.DTOs;
using ResumeCraft_API.Models.Models;

namespace ResumeCraft_API.Services.IServices
{
    public interface IResumeService
    {
        Task<IEnumerable<Resume>> GetResumesByUserIdAsync(int userId);
        Task AddResumeAsync(ResumeDto resumeDto);
        Task DeleteResumeAsync(int resumeId);
        Task UpdateResumeAsync(int resumeId, ResumeDto resumeDto);

    }
}
