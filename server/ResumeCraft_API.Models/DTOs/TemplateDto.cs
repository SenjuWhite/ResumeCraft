using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumeCraft_API.Models.Interfaces;

namespace ResumeCraft_API.Models.DTOs
{
    public class TemplateDto : IIdentifiable<int?>
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string PreviewImage { get; set; }
    }
}
