using Abp.Authorization;
using MetroStation.Authorization.Roles;
using MetroStation.Authorization.Users;

namespace MetroStation.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
