using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResumeCraft_API.DataAccess.UnitOfWork;
using ResumeCraft_API.Models.DTOs;
using ResumeCraft_API.Services.IServices;

namespace ResumeCraft_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IResumeService _resumeService;
        public ResumeController(IResumeService resumeService, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _resumeService = resumeService;
        }
        [HttpPost]
        public async Task<IActionResult> AddResume([FromBody] ResumeDto resumeDto)
        {
            try
            {
                await _resumeService.AddResumeAsync(resumeDto);

                return CreatedAtAction(nameof(AddResume), resumeDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Виникла помилка: {ex.Message}");
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateResume([FromBody] ResumeDto resumeDto, int resumeId)
        {
            await _resumeService.UpdateResumeAsync(resumeId, resumeDto);   
            return Ok(resumeDto);
        }

    }
}
