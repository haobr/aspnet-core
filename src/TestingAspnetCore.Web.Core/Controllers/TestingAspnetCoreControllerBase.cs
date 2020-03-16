using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TestingAspnetCore.Controllers
{
    public abstract class TestingAspnetCoreControllerBase: AbpController
    {
        protected TestingAspnetCoreControllerBase()
        {
            LocalizationSourceName = TestingAspnetCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
