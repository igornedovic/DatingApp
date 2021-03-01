using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace DatingAppNew.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}