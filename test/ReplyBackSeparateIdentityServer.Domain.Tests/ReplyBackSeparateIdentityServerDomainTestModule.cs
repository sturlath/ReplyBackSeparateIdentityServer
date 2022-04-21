using ReplyBackSeparateIdentityServer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ReplyBackSeparateIdentityServer;

[DependsOn(
    typeof(ReplyBackSeparateIdentityServerEntityFrameworkCoreTestModule)
    )]
public class ReplyBackSeparateIdentityServerDomainTestModule : AbpModule
{

}
