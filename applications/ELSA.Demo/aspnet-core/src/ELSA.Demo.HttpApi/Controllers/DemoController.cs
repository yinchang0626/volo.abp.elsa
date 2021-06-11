using ELSA.Demo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ELSA.Demo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class DemoController : AbpController
    {
        protected DemoController()
        {
            LocalizationResource = typeof(DemoResource);
        }
    }
}