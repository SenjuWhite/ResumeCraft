using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.Models.Models
{
    public class Resume
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TemplateId { get; set; }
        public int? Age { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
        public int? ZipCode { get; set; }
        public string? Summary { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public User User { get; set; }
        public Template Template { get; set; }
        public ICollection<Employment> Employments { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<Education> Educations { get; set; }

        public ICollection<Language> Languages { get; set; }
        public ICollection<SocialLink> SocialLinks { get; set; }
        public ICollection<CustomSection> CustomSections { get; set; }
    }
}
