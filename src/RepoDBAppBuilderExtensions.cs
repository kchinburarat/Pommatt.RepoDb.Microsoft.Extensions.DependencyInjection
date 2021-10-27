using Microsoft.AspNetCore.Builder;
using RepoDb;
using System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RepoDBAppBuilderExtensions
    {
        public static IApplicationBuilder UseRepoDB(this IApplicationBuilder app)
        {
            var entityTypeConfigurations = app.ApplicationServices.GetService<IEnumerable<IEntityTypeConfiguration>>();
            foreach (var entityTypeConfiguration in entityTypeConfigurations)
            {
                entityTypeConfiguration.ConfigureHandler(app);
            }
            return app;
        }
    }
}
