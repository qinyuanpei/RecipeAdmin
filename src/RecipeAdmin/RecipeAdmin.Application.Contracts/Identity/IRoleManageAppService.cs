using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;

namespace RecipeAdmin.Identity
{
    public interface IRoleManageAppService
    {
        Task<PagedResultDto<IdentityRoleDto>> GetListAsync(QuickSearchIdentityRolesInput input);
    }
}
