using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Http;

namespace electronAngular2{
        public class Startup
    {
        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseMvcWithDefaultRoute();

            // static files documented really well here: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/static-files
            app.UseStaticFiles();
            // we only want one package.json and one set of "node_modules" so map it so the wwwroot can access it
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new Microsoft.Extensions.FileProviders.PhysicalFileProvider(
                    System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "node_modules")),
                RequestPath = new PathString("/node_modules")
            });
        }
    }
}