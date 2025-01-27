using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumeCraft_API.Models.Interfaces;

namespace ResumeCraft_API.Models.DTOs
{
    public class SocialLinkDto : IIdentifiable<int?>
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Link { get; set; }
        public int ResumeId { get; set; }
    }
}
