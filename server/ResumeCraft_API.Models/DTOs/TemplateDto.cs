using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.Models.DTOs
{
    public class TemplateDto
    {
        public string Name { get; set; }
        [Required]
        public string PreviewImage { get; set; }
    }
}
