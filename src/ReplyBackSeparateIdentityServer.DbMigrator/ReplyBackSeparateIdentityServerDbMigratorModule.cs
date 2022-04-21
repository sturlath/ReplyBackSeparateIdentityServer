using ReplyBackSeparateIdentityServer.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ReplyBackSeparateIdentityServer.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ReplyBackSeparateIdentityServerEntityFrameworkCoreModule),
    typeof(ReplyBackSeparateIdentityServerApplicationContractsModule)
    )]
public class ReplyBackSeparateIdentityServerDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
