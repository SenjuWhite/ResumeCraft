using ResumeCraft_API.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.Models.DTOs
{
    public class ResumeDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int TemplateId { get; set; }
        public int? Age { get; set; }
        public string? Position { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
        public int? ZipCode { get; set; }
        public string? Summary { get; set; }
        //public User User { get; set; }
        public ICollection<EmploymentDto>? Employments { get; set; }
        public ICollection<SkillDto>? Skills { get; set; }
        public ICollection<EducationDto>? Educations { get; set; }

        public ICollection<LanguageDto>? Languages { get; set; }
        public ICollection<SocialLinkDto>? SocialLinks { get; set; }
        public ICollection<CustomSectionDto>? CustomSections { get; set; }
    }
}
