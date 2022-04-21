using ReplyBackSeparateIdentityServer.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ReplyBackSeparateIdentityServer.Blazor;

public abstract class ReplyBackSeparateIdentityServerComponentBase : AbpComponentBase
{
    protected ReplyBackSeparateIdentityServerComponentBase()
    {
        LocalizationResource = typeof(ReplyBackSeparateIdentityServerResource);
    }
}
