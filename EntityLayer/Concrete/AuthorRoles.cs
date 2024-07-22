using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Concrete
{
    public class AuthorRoles : IdentityRole<int>
    {
        public int RoleValue { get; set; }
    }
}
