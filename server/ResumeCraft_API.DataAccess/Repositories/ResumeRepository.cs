using ResumeCraft_API.DataAccess.Repositories.IRepositories;
using ResumeCraft_API.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.DataAccess.Repositories
{
    public class ResumeRepository : Repository<Resume>, IResumeRepository
    {
        private ApplicationDbContext _db;
        public ResumeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }
    }
}
