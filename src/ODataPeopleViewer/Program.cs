using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ODataPeopleViewer.Menu;
using ODataPeopleViewer.Services;
using System;

namespace ODataPeopleViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MainAsync(args).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static async System.Threading.Tasks.Task MainAsync(string[] args)
        {
            bool showMenu = true;

            // Create service collection
            var services = Services.ApplicationServices.ConfigureServices();

            // Create service provider
            var serviceProvider = services.BuildServiceProvider();

            var startupValidations = serviceProvider.GetService<IStartupValidationService>();
            var validationResponse = startupValidations.PerformStartupValidations();

            if (validationResponse.ValidationsPassed)
            {
                var menuLogic = serviceProvider.GetService<IMenuLogic>();
                while (showMenu)
                {
                    showMenu = await menuLogic.ShowMainMenu();
                }
            }
            else
            {
                Console.WriteLine(validationResponse.ErrorMessage);
                Console.ReadLine();
            }
        }
    }
}
