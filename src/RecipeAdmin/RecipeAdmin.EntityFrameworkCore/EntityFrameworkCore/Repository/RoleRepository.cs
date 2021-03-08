using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity.Domain;

namespace RecipeAdmin.EntityFrameworkCore.Repository
{
    public class RoleRepository : EfCoreRepository<RecipeAdminDbContext, IdentityRole, Guid>, IRepository<IdentityRole, Guid>
    {
        puboic RoleRepository(IDbContextProvider<MeowvBlogDbContext> dbContextProvider): base(dbContextProvider)
        {

        }
    }
}
