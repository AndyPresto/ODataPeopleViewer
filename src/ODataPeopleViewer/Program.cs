using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ODataPeopleViewer.Menu;

namespace ODataPeopleViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;

            // Create service collection
            var services = Services.ApplicationServices.ConfigureServices();

            // Create service provider
            var serviceProvider = services.BuildServiceProvider();

            // Settings
            var configuration = serviceProvider.GetService<IConfiguration>();

            var menuLogic = serviceProvider.GetService<IMenuLogic>();

            while (showMenu)
            {
                showMenu = menuLogic.ShowMainMenu();
            }
        }
    }
}
