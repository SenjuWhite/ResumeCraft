using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.Models.Models
{
    public class Education
    {
        public int Id { get; set; }
        public int ResumeId { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Degree { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
        public Resume Resume { get; set; }
         
    }
}
