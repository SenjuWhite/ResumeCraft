using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumeCraft_API.Models.Interfaces;

namespace ResumeCraft_API.Models.Models
{
    public class Resume : IIdentifiable<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TemplateId { get; set; }
        public string? Name { get; set; }
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
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        //public User User { get; set; }
        public Template Template { get; set; }
        public ICollection<Employment> Employments { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<Education> Educations { get; set; }

        public ICollection<Language> Languages { get; set; }
        public ICollection<SocialLink> SocialLinks { get; set; }
        public ICollection<CustomSection> CustomSections { get; set; }
    }
}
