using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.Models.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Email { get; set; } 
        public string? PasswordHash { get; set; } 
        public string Username { get; set; } 
        public string? GoogleId { get; set; }
        public bool IsGoogleAuth { get; set; }
        public string? ResetPasswordToken { get; set; }
        public DateTime? ResetTokenExpiration { get; set; }
        public ICollection<Resume> Resumes { get; set; }
    }
}
