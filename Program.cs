using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace electronAngular2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseContentRoot(System.IO.Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();
    }
}
