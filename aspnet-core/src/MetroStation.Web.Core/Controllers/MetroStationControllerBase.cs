using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MetroStation.Controllers
{
    public abstract class MetroStationControllerBase: AbpController
    {
        protected MetroStationControllerBase()
        {
            LocalizationSourceName = MetroStationConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
