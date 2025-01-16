using ResumeCraft_API.DataAccess.Repositories.IRepositories;
using ResumeCraft_API.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.DataAccess.Repositories
{
    public class CustomSectionRepository : Repository<CustomSection>, ICustomSectionRepository
    {
        private ApplicationDbContext _db;
        public CustomSectionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }
    }
}
