using Kreata.Backend.Context;
using Kreata.Backend.Repos.Base;
using Kreta.Shared.Models;

namespace Kreata.Backend.Repos
{
    public class TeacherRepo<TDbContext> : BaseRepo<TDbContext, Teacher>, ITeacherRepo where TDbContext : KretaContext
    {
        public TeacherRepo(TDbContext? dbContext) : base(dbContext) 
        {
            
        }
    }
}
