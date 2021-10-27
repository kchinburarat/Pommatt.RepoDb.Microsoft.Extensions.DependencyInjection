using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace RepoDb
{
    public interface IEntityTypeConfiguration
    {
        void Configure(IServiceCollection services);

        void ConfigureHandler(IApplicationBuilder app);
    }
}
