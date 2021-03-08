using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;

namespace module.StartupFilters
{
    internal class ModuleStartupFilter : IStartupFilter
    {
        Action<IApplicationBuilder> IStartupFilter.Configure(Action<IApplicationBuilder> next)
        {
            return builder =>
            {
                Console.WriteLine("Configuring Module");

                next(builder);
            };
        }
    }
}
