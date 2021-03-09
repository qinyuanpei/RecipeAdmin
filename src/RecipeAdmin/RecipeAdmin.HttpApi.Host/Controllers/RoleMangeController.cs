using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAdmin.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Identity;

namespace RecipeAdmin.Controllers
{
    [RemoteService(Name = IdentityRemoteServiceConsts.RemoteServiceName)]
    [Area("identity")]
    [ControllerName("Role")]
    [Route("api/identity/roles")]
    public class RoleMangeController : AbpController, IRoleManageAppService
    {
        private readonly IRoleManageAppService _roleMangeAppService;
        public RoleMangeController(IRoleManageAppService roleMangeAppService)
        {
            _roleMangeAppService = roleMangeAppService;
        }

        [HttpGet]
        [Route("search")]
        public Task<PagedResultDto<IdentityRoleDto>> GetListAsync(QuickSearchIdentityRolesInput input)
        {
            return _roleMangeAppService.GetListAsync(input);
        }
    }
}
