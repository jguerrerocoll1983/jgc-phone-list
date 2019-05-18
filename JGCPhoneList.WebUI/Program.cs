using System;
using JGCPhoneList.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace JGCPhoneList.WebUI
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var context = scope.ServiceProvider.GetService<IJgcPhoneListDbContext>();

                    JgcPhoneListInitializer.Initialize(context as JgcPhoneListDbContext);
                }
                catch (Exception ex)
                {
                    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while migrating or initializing the database.");
                }
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
