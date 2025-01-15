using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.Models.Models
{
    public class SocialLink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}
