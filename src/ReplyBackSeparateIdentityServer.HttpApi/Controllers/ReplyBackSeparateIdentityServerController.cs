using ReplyBackSeparateIdentityServer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ReplyBackSeparateIdentityServer.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ReplyBackSeparateIdentityServerController : AbpControllerBase
{
    protected ReplyBackSeparateIdentityServerController()
    {
        LocalizationResource = typeof(ReplyBackSeparateIdentityServerResource);
    }
}
