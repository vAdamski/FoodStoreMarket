using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using Microsoft.AspNetCore;
using System.Reflection;

namespace FoodStoreMarket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Add configuration to add new Logger Serilog.AspNetCore
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();

            try
            {
                Log.Information("Application is starting up");
                CreateHostBuilder(args).UseSerilog().Build().Run();
            }
            catch (Exception e)
            {
                Log.Fatal(e, "Could not start up application");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                var env = hostingContext.HostingEnvironment;
                config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsetings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsetings.Local.json", optional: true, reloadOnChange: true);

                if (env.IsDevelopment())
                {
                    var appAssembly = Assembly.Load(new AssemblyName(env.ApplicationName));
                    config.AddUserSecrets(appAssembly, optional: true);
                }

                config.AddEnvironmentVariables();

                if (args != null)
                {
                    config.AddCommandLine(args);
                }
            })
            .UseStartup<Startup>();
    }
}
