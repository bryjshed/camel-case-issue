using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace UserService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();
            
            var env = config["ASPNETCORE_ENVIRONMENT"] ?? "Development";
            var urls = config["ASPNETCORE_URLS"] ?? "http://*:11009";

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseEnvironment(env)
                .UseConfiguration(config)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseUrls(urls)
                .Build();

            host.Run();
        }
    }
}
