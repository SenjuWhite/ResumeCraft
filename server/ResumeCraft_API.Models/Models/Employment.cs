using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.Models.Models
{
    public class Employment
    {
        public int Id { get; set; }
        public int ResumeId { get; set; }
        public string? Company { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? City { get; set; }

        [Required]
        public string Description { get; set; }

        public Resume Resume { get; set; }
    }
}

