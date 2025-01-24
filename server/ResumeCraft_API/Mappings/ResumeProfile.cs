using AutoMapper;
using ResumeCraft_API.Models.DTOs;
using ResumeCraft_API.Models.Models;

namespace ResumeCraft_API.Mappings
{
    public class ResumeProfile : Profile
    {
        public ResumeProfile()
        {
            CreateMap<EmploymentDto, Employment>();
            CreateMap<CustomSectionDto, CustomSection>();
            CreateMap<EducationDto, Education>();
            CreateMap<EmploymentDto, Employment>();
            CreateMap<LanguageDto, Language>();
            CreateMap<SkillDto, Skill>();
            CreateMap<SocialLinkDto, SocialLink>();




        }
    }
}
