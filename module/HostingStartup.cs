using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using module;
using module.StartupFilters;
using System;

[assembly: HostingStartup(typeof(HostingStartup))]

namespace module
{
    public class HostingStartup : IHostingStartup
    {
        void IHostingStartup.Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((_, services) =>
            {
                services.AddTransient<IStartupFilter, ModuleStartupFilter>();

                Console.WriteLine("Configuring services for Module");
            });

            // Use an IStartupFilter instead. See StartupFilters\ModuleStartupFilter.cs
            //builder.Configure(app =>
            //{
            //    Console.WriteLine("Configuring Module");
            //});
        }
    }
}
