using ResumeCraft_API.DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICustomSectionRepository CustomSection { get; }
        IEducationRepository Education { get; }
        IEmploymentRepository Employment { get; }
        ILanguageRepository Language { get; }
        IUserRepository User { get; }
        IResumeRepository Resume { get; }
        ISkillRepository Skill { get; }
        ISocialLinkRepository SocialLink{ get; }
        ITemplateRepository Template { get; }
        Task SaveAsync();

    }
}
