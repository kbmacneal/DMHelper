using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace DM_helper
{
    public class Program
    {
        public static Random rand { get; set; } = new Random();

       public static void Main (string[] args) {
            BuildWebHost (args).Run ();
        }

        public static IWebHost BuildWebHost (string[] args) =>
            WebHost.CreateDefaultBuilder (args)
            .ConfigureKestrel (kestrel => {
                kestrel.ListenLocalhost (4999);
            })
            .UseStartup<Startup> ()
            .UseKestrel()
            .Build ();
    }
}