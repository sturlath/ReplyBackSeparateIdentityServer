using System;
using System.Collections.Generic;
using System.Text;
using ReplyBackSeparateIdentityServer.Localization;
using Volo.Abp.Application.Services;

namespace ReplyBackSeparateIdentityServer;

/* Inherit your application services from this class.
 */
public abstract class ReplyBackSeparateIdentityServerAppService : ApplicationService
{
    protected ReplyBackSeparateIdentityServerAppService()
    {
        LocalizationResource = typeof(ReplyBackSeparateIdentityServerResource);
    }
}
