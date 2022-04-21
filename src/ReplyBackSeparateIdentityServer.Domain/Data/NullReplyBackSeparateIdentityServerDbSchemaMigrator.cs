using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ReplyBackSeparateIdentityServer.Data;

/* This is used if database provider does't define
 * IReplyBackSeparateIdentityServerDbSchemaMigrator implementation.
 */
public class NullReplyBackSeparateIdentityServerDbSchemaMigrator : IReplyBackSeparateIdentityServerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
