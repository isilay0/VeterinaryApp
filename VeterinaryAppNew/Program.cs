
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Core;
using System;
using System.Windows.Forms;

namespace VeterinaryAppNew
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            IHost host = CreateHostBuilder().Build();
            MainForm mainForm = host.Services.GetRequiredService<MainForm>();

            Application.Run(mainForm);
        }

        private static IHostBuilder CreateHostBuilder()
        {
            
            return Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(config =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    Logger logger = new LoggerConfiguration().ReadFrom.Configuration(context.Configuration).CreateLogger();
                    services.AddSerilog(logger);
                    services.AddSingleton<MainForm>();
                });
        }
    }
}