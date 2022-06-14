using LocalIdentity.Admin.EntityFramework.Shared.DbContexts;
using LocalIdentity.STS.Identity.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LocalIdentity.STS.Identity.Configuration.Test
{
    public class StartupTest : Startup
    {
        public StartupTest(IWebHostEnvironment environment, IConfiguration configuration) : base(environment, configuration)
        {
        }

        public override void RegisterDbContexts(IServiceCollection services)
        {
            services.RegisterDbContextsStaging<AdminIdentityDbContext, IdentityServerConfigurationDbContext, IdentityServerPersistedGrantDbContext, IdentityServerDataProtectionDbContext>();
        }
    }
}







