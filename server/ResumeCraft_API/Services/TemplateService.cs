using ResumeCraft_API.DataAccess.UnitOfWork;
using ResumeCraft_API.Models.DTOs;
using ResumeCraft_API.Models.Models;
using ResumeCraft_API.Services.IServices;

namespace ResumeCraft_API.Services
{
    public class TemplateService : ITemplateService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TemplateService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddTemplateAsync(TemplateDto templateDto)
        {
            if (templateDto == null)
            
               throw new ArgumentNullException(nameof(templateDto));

            var template = new Template
            {
                Name = templateDto.Name,
                PreviewImage = templateDto.PreviewImage,
                CreatedAt = DateTime.Now
            };
            await _unitOfWork.Template.AddAsync(template);
            await _unitOfWork.SaveAsync();
        }
    }
}
