using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ReplyBackSeparateIdentityServer;

[Dependency(ReplaceServices = true)]
public class ReplyBackSeparateIdentityServerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ReplyBackSeparateIdentityServer";
}
