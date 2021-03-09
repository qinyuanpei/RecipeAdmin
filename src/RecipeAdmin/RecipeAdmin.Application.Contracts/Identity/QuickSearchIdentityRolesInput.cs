using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace RecipeAdmin.Identity
{
    public class QuickSearchIdentityRolesInput : PagedAndSortedResultRequestDto
    {
        public string RoleName { get; set; }
    }
}
