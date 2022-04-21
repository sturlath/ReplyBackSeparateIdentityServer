using Volo.Abp.Modularity;

namespace ReplyBackSeparateIdentityServer;

[DependsOn(
    typeof(ReplyBackSeparateIdentityServerApplicationModule),
    typeof(ReplyBackSeparateIdentityServerDomainTestModule)
    )]
public class ReplyBackSeparateIdentityServerApplicationTestModule : AbpModule
{

}
