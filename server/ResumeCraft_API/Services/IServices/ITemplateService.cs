using ResumeCraft_API.Models.DTOs;

namespace ResumeCraft_API.Services.IServices
{
    public interface ITemplateService
    {
        Task AddTemplateAsync(TemplateDto templateDto);

    }
}
