﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumeCraft_API.Models.Interfaces;

namespace ResumeCraft_API.Models.DTOs
{
    public class EducationDto : IIdentifiable<int?>
    {
        public int? Id { get; set; }
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
