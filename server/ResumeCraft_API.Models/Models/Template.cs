using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.Models.Models
{
    public class Template
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string PreviewImage { get; set; }
        public DateTime CreatedAt {  get; set; }
        public ICollection<Resume> Resumes { get; set; }
    }
}
