using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using module;

namespace hsdemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .UseSetting(WebHostDefaults.HostingStartupAssembliesKey, $"{typeof(HostingStartup).Assembly.FullName}")
                        .UseStartup<Startup>();
                });
    }
}
