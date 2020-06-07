using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace CoronaApp.Api
{
    public class Program
    {
         public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
        //            .AddJsonFile("appsettings.json")
        //.Build();
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
        .Build();
        //IConfiguration Configuration = new ConfigurationBuilder()


        public static void Main(string[] args)
        {
           
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .CreateLogger();

            BuildWebHost(args).Run();
            Log.Information("Project started at {time}", DateTime.UtcNow);
        }

        public static IWebHost BuildWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
               .UseStartup<Startup>()
               .UseConfiguration(Configuration)
               .UseSerilog()
               .Build();
    }
    // public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
    //.SetBasePath(Directory.GetCurrentDirectory())
    //.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    //.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
    //.Build();
    // public static void Main(string[] args)
    // {
    //     Log.Logger = new LoggerConfiguration()
    //     .ReadFrom.Configuration(Configuration)
    //     .CreateLogger();

    //     BuildWebHost(args).Run();

    //     CreateHostBuilder(args).Build().Run();
    // }

    // public static IHostBuilder CreateHostBuilder(string[] args)
    // {
    //     //WebHost.CreateDefaultBuilder(args)
    //     //  .UseStartup<Startup>()
    //     //  .UseConfiguration(Configuration)
    //     //  .UseSerilog()
    //     //  .Build();
    //     return Host.CreateDefaultBuilder(args)
    //       .ConfigureWebHostDefaults(webBuilder =>
    //       {
    //           webBuilder.UseStartup<Startup>()
    //           .UseConfiguration(Configuration)
    //     .UseSerilog();
    //       });
    // } 
    // //.ConfigureLogging((context, logging) =>
    //     //{
    //     //    logging.ClearProviders();
    //     //    logging.AddConfiguration(context.Configuration.GetSection("Logging"));
    //     //})

    // //    Log.Logger = new LoggerConfiguration()
    // //                .ReadFrom.Configuration(Configuration)
    // //                .CreateLogger();
    // //}
    // //WebHost.CreateDefaultBuilder(args)
    // //  .UseStartup<Startup>()
    // //  .UseConfiguration(Configuration)
    // //  .UseSerilog()
    // //  .Build();
}

