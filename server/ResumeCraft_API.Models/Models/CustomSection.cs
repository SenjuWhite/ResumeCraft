using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.Models.Models
{
    public class CustomSection
    {
        public int Id { get; set; }
        public int ResumeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public Resume Resume { get; set; }
    }


}
