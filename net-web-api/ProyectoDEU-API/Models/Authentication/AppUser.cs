using Microsoft.AspNetCore.Identity;

namespace ProyectoDEU_API.Models.Authentication
{
    public class AppUser : IdentityUser<Guid>
    {
        public AppUser() : base()
        {

        }

        public AppUser(string userName) : base(userName)
        {

        }

        //public DateTimeOffset CreationDate { get; set; }
        //public DateTimeOffset? LastLoginDate { get; set; }
        //public DateTimeOffset? LastActivityDate { get; set; }
        //public bool IsApproved { get; set; }

    }

    public class AppRole : IdentityRole<Guid>
    {
        public AppRole() : base()
        {

        }

        public AppRole(string roleName) : base(roleName)
        {

        }
    }


    public class AppUserToken : IdentityUserToken<Guid>
    {

    }

    public class AppUserClaim : IdentityUserClaim<Guid>
    {

    }

    public class AppRoleClaim : IdentityRoleClaim<Guid>
    {

    }

    public class AppUserLogin : IdentityUserLogin<Guid>
    {

    }

    public class AppUserRole : IdentityUserRole<Guid>
    {

    }
}
