using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KursSepeti.Services.Catalog.Dtos;
using KursSepeti.Services.Catalog.Services;
using Microsoft.Extensions.DependencyInjection;

namespace KursSepeti.Services.Catalog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var  host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var categoryService = serviceProvider.GetRequiredService<ICategoryService>();

                if (!categoryService.GetAllAsync().Result.Data.Any())
                {
                    categoryService.CreateAsync(new CategoryDto{Name = "Asp.net Core Kursu"}).Wait();
                    categoryService.CreateAsync(new CategoryDto{Name = "Asp.net Core API Kursu"}).Wait();
                }
            }
            
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
