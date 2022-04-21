using System.Threading.Tasks;

namespace ReplyBackSeparateIdentityServer.Data;

public interface IReplyBackSeparateIdentityServerDbSchemaMigrator
{
    Task MigrateAsync();
}
