using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Mozg.DB;
using Mozg.Services;
using Mozg.Models;

namespace Mozg
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = ConfigureServices();

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<Form1>();
                Application.Run(mainForm);
            }
        }

        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            var builder = new ConfigurationBuilder();

            var configuration = builder.Build();

            string? forgateConnectionString = configuration.GetConnectionString("Connection");

            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(forgateConnectionString);
            });

            services.AddTransient<Form1>();
            services.AddTransient<StepikService>();
            services.AddTransient<LeetCodeService>();
            services.AddTransient<IApiServiceFactory, ApiServiceFactory>();

            return services;
        }
    }
}