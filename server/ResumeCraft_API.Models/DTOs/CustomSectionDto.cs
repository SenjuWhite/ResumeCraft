using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.Models.DTOs
{
    public class CustomSectionDto
    {
        public int ResumeId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
