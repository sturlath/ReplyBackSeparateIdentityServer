using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ReplyBackSeparateIdentityServer.Blazor;

[Dependency(ReplaceServices = true)]
public class ReplyBackSeparateIdentityServerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ReplyBackSeparateIdentityServer";
}
