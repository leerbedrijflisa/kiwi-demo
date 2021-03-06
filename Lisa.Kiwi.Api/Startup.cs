﻿using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Lisa.Kiwi.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();
            app.UseMvc();
        }

        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}