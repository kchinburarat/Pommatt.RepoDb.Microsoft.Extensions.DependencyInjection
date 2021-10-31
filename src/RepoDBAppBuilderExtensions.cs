using Microsoft.AspNetCore.Builder;
using RepoDb;
using System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RepoDBAppBuilderExtensions
    {
        private static bool _isCallUseRepoDB = false;
        public static IApplicationBuilder UseRepoDB(this IApplicationBuilder app)
        {
            if (!_isCallUseRepoDB)
            {
                var entityTypeConfigurations = app.ApplicationServices.GetService<IEnumerable<IEntityTypeConfiguration>>();
                foreach (var entityTypeConfiguration in entityTypeConfigurations)
                {
                    entityTypeConfiguration.ConfigureHandler(app);
                }
                _isCallUseRepoDB = true;
            }

            return app;
        }
    }
}
