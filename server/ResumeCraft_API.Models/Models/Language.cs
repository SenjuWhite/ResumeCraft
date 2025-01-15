using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.Models.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(1, 5, ErrorMessage = "Level must be between 1 and 5.")]
        public int? Level { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}
