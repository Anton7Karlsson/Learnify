using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
          var host =  CreateHostBuilder(args).Build();
            using var scope = host.Services.CreateScope();
            var Services = scope.ServiceProvider;
            
            var logger = Services.GetRequiredService<ILogger<Program>>();
            try
            {
                var userManager = Services.GetRequiredService<UserManager<User>>();
                var context = Services.GetRequiredService<StoreContext>();
                await context.Database.MigrateAsync();
                await StoreContextSeed.SeedAsync(context, logger, userManager);
            } 
            catch(Exception ex)
            {
                
                logger.LogError(ex, "Something wrong happend during migration");
            }

            await host.RunAsync();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
