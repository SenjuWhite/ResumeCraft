﻿using ResumeCraft_API.DataAccess.Repositories;
using ResumeCraft_API.DataAccess.Repositories.IRepositories;
using ResumeCraft_API.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public ICustomSectionRepository CustomSection { get; private set; }
        public IEducationRepository Education { get; private set; }
        public IEmploymentRepository Employment { get; private set; }
        public ILanguageRepository Language { get; private set; }
        public IUserRepository User { get; private set; }
        public IResumeRepository Resume { get; private set; }
        public ISkillRepository Skill { get; private set; }
        public ISocialLinkRepository SocialLink { get; private set; }
        public ITemplateRepository Template { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            CustomSection = new CustomSectionRepository(_db);
            Education = new EducationRepository(_db);
            Employment = new EmploymentRepository(_db);
            Language = new LanguageRepository(_db);
            User = new UserRepository(_db);
            Resume = new ResumeRepository(_db);
            Skill = new SkillRepository(_db);
            Template = new TemplateRepository(_db);
            SocialLink = new SocialLinkRepository(_db);
            
        }
        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
