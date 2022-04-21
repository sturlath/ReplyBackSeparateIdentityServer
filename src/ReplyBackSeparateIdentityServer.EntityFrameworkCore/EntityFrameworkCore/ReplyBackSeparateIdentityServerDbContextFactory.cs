using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ReplyBackSeparateIdentityServer.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ReplyBackSeparateIdentityServerDbContextFactory : IDesignTimeDbContextFactory<ReplyBackSeparateIdentityServerDbContext>
{
    public ReplyBackSeparateIdentityServerDbContext CreateDbContext(string[] args)
    {
        ReplyBackSeparateIdentityServerEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ReplyBackSeparateIdentityServerDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ReplyBackSeparateIdentityServerDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ReplyBackSeparateIdentityServer.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
