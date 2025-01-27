using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumeCraft_API.Models.Interfaces;

namespace ResumeCraft_API.Models.DTOs
{
    public class EmploymentDto : IIdentifiable<int?>
    {
        public int? Id { get; set; }
        public int ResumeId { get; set; }
        public string? Company { get; set; }
        public string? Position { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? City { get; set; }
        public string? Description { get; set; }
    }
}
