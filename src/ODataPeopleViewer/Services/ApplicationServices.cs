using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ODataPeopleViewer.Menu;
using ODataPeopleViewer.OData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataPeopleViewer.Services
{
    public class ApplicationServices
    {
        public static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            #region Configuration from appsettings file
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .AddEnvironmentVariables()
                .Build();
            #endregion

            #region Settings
            services.Configure<IConfiguration>(configuration);
            services.AddSingleton<IConfiguration>(configuration);
            services.BuildServiceProvider();
            #endregion

            #region Main DI services
            services.AddSingleton<IStartupValidationService, StartupValidationService>();
            services.AddSingleton<IMenuLogic, MenuLogic>();
            services.AddSingleton<IOData, OData.OData>();
            services.AddSingleton<IMenuPrintingService, MenuPrintingService>();
            #endregion

            return services;
        }
    }
}
