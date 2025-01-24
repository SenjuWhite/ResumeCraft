using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResumeCraft_API.DataAccess.UnitOfWork;
using ResumeCraft_API.Models.DTOs;
using ResumeCraft_API.Services;
using ResumeCraft_API.Services.IServices;

namespace ResumeCraft_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplateController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITemplateService _templateService;
        public TemplateController(ITemplateService templateService, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _templateService = templateService;
        }
        [HttpPost]
        public async Task<IActionResult> AddTemplate([FromBody] TemplateDto templateDto)
        {
            try
            {
                await _templateService.AddTemplateAsync(templateDto);

                return CreatedAtAction(nameof(AddTemplate), templateDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Виникла помилка: {ex.Message}");
            }
        }
    }
}
