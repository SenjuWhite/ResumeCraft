﻿using AutoMapper;
using ResumeCraft_API.DataAccess.Repositories.IRepositories;
using ResumeCraft_API.DataAccess.UnitOfWork;
using ResumeCraft_API.Models.DTOs;
using ResumeCraft_API.Models.Models;
using ResumeCraft_API.Services.IServices;

namespace ResumeCraft_API.Services
{
    public class ResumeSectionService<T> : IResumeSectionService<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ResumeSectionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddAsync(T item)
        {
            switch (item)
            {
                case EmploymentDto employmentDto:  
                    var employment = _mapper.Map<Employment>(employmentDto);
                    await _unitOfWork.Employment.AddAsync(employment);
                    break;
                case CustomSectionDto customSectionDto:
                    var customSection = _mapper.Map<CustomSection>(customSectionDto);
                    await _unitOfWork.CustomSection.AddAsync(customSection);
                    break;
                case EducationDto educationDto:
                    var education = _mapper.Map<Education>(educationDto);
                    await _unitOfWork.Education.AddAsync(education);
                    break;
                case LanguageDto languageDto:
                    var language = _mapper.Map<Language>(languageDto);
                    await _unitOfWork.Language.AddAsync(language);
                    break;
                case SkillDto skillDto:
                    var skill = _mapper.Map<Skill>(skillDto);
                    await _unitOfWork.Skill.AddAsync(skill);
                    break;
                case SocialLinkDto socialLinkDto:
                    var socialLink = _mapper.Map<SocialLink>(socialLinkDto);
                    await _unitOfWork.SocialLink.AddAsync(socialLink);
                    break;
            }
            await _unitOfWork.SaveAsync();                
        }
        public Task DeleteAsync(int itemId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }
    }
}
