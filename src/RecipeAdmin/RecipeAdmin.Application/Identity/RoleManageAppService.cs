using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;

namespace RecipeAdmin.Identity
{
    [Authorize(IdentityPermissions.Roles.Default)]
    public class RoleManageAppService : ApplicationService, IRoleManageAppService
    {
        private readonly IdentityRoleManager _roleManager;
        private readonly EfCoreIdentityRoleRepository _roleRepository;
        public RoleManageAppService(
            IdentityRoleManager roleManager,
            EfCoreIdentityRoleRepository roleRepository)
        {
            _roleManager = roleManager;
            _roleRepository = roleRepository;
        }

        public async Task<PagedResultDto<IdentityRoleDto>> GetListAsync(QuickSearchIdentityRolesInput input)
        {
            var total = await _roleRepository.GetCountAsync();
            var roles = _roleRepository
                .WhereIf(!string.IsNullOrEmpty(input.RoleName), r => r.Name.Contains(input.RoleName))
                .OrderBy(x => x.Name)
                .PageBy(input)
                .ToList();

            return new PagedResultDto<IdentityRoleDto>
            {
                TotalCount = total,
                Items = ObjectMapper.Map<List<IdentityRole>, List<IdentityRoleDto>>(roles)
            };
        }
    }
}
