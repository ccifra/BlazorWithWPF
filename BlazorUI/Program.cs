using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace BlazorUI
{
    public class ServerManager
    {
        private static IHost _host;

        public static void RunServer(string[] args)
        {
            _host = CreateHostBuilder(args).Build();
            _host.Start();
        }

        public static void StopServer()
        {
            _host.Dispose();
            _host = null;
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
