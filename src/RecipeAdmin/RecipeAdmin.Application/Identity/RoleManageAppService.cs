﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Identity;

namespace RecipeAdmin.Identity
{
    public class RoleManageAppService : IdentityRoleAppService
    {
        public RoleManageAppService(
            IdentityRoleManager roleManager,
            IIdentityRoleRepository roleRepository)
            : base(roleManager, roleRepository)
        {

        }

        public async Task<List<IdentityRoleDto>> GetRolesByText(GetIdentityRolesInput input, string text)
        {
            await Task.FromResult(new List<IdentityRoleDto>());
        }

    }
}