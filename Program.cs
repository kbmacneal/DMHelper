using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace DM_helper
{
    public class Program
    {
        public static Random rand { get; set; } = new Random();

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseUrls("http://localhost:4999")
                .UseStartup<Startup>();
    }
}