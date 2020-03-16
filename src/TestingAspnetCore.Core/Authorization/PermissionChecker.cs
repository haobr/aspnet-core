using Abp.Authorization;
using TestingAspnetCore.Authorization.Roles;
using TestingAspnetCore.Authorization.Users;

namespace TestingAspnetCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
