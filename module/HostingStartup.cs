using Microsoft.AspNetCore.Hosting;
using module;
using System;

[assembly: HostingStartup(typeof(HostingStartup))]

namespace module
{
    public class HostingStartup : IHostingStartup
    {
        void IHostingStartup.Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices(_ =>
            {
                Console.WriteLine("Configuring services for Module");
            });

            builder.Configure(app =>
            {
                Console.WriteLine("Configuring Module");
            });
        }
    }
}
