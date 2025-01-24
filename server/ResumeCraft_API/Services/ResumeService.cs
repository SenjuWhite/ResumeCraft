using ResumeCraft_API.DataAccess.UnitOfWork;
using ResumeCraft_API.Models.DTOs;
using ResumeCraft_API.Models.Models;
using ResumeCraft_API.Services.IServices;

namespace ResumeCraft_API.Services
{
    public class ResumeService : IResumeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ResumeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
      
        public async Task AddResumeAsync(ResumeDto resumeDto)
        {
            ArgumentNullException.ThrowIfNull(resumeDto);

            var resume = new Resume
            {
                UserId = resumeDto.UserId,
                TemplateId = resumeDto.TemplateId,
                Name = resumeDto.Name,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
               
            };

            await _unitOfWork.Resume.AddAsync(resume);
            await _unitOfWork.SaveAsync();

        }

        public async Task DeleteResumeAsync(int resumeId)
        {
            if (resumeId <= 0)
            {
                throw new ArgumentException("Resume ID must be greater than zero.", nameof(resumeId));
            }

            var resume = await _unitOfWork.Resume.GetValueAsync(res => res.Id == resumeId);
            if (resume == null)
            {
                throw new KeyNotFoundException($"Resume with ID {resumeId} not found.");
            }

            await _unitOfWork.Resume.DeleteAsync(resume);
            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<Resume>> GetResumesByUserIdAsync(int userId)
        {
            if (userId <= 0)
            {
                throw new ArgumentException("User ID must be greater than zero.", nameof(userId));
            }

            var resumes = await _unitOfWork.Resume.GetValuesAsync(res => res.UserId == userId);

            return resumes ?? Enumerable.Empty<Resume>();
        }

        public async Task UpdateResumeAsync(int resumeId, ResumeDto resumeDto)
        {
            if (resumeId <= 0)
            {
                throw new ArgumentException("Resume ID must be greater than zero.", nameof(resumeId));
            }
            ArgumentNullException.ThrowIfNull(resumeDto);

            var resume = await _unitOfWork.Resume.GetValueAsync(res => res.Id == resumeId);

            if (resume == null)
            {
                throw new KeyNotFoundException($"Resume with ID {resumeId} not found.");
            }
            await _unitOfWork.Resume.UpdateAsync(resume);
            await _unitOfWork.SaveAsync(); 
        }
    }
}
