using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumeCraft_API.Models.Interfaces;

namespace ResumeCraft_API.Models.Models
{
    public class Template : IIdentifiable<int>
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
