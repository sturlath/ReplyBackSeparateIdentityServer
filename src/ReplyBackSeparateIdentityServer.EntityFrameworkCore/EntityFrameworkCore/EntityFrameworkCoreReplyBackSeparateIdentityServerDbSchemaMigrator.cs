using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReplyBackSeparateIdentityServer.Data;
using Volo.Abp.DependencyInjection;

namespace ReplyBackSeparateIdentityServer.EntityFrameworkCore;

public class EntityFrameworkCoreReplyBackSeparateIdentityServerDbSchemaMigrator
    : IReplyBackSeparateIdentityServerDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreReplyBackSeparateIdentityServerDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ReplyBackSeparateIdentityServerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ReplyBackSeparateIdentityServerDbContext>()
            .Database
            .MigrateAsync();
    }
}
