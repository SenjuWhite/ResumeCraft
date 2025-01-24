using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.Models.DTOs
{
    public class EducationDto
    {
        public int ResumeId { get; set; }
        public string? Name { get; set; }
        public string? Degree { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
    }
}
