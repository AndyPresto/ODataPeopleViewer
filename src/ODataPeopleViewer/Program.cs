using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ODataPeopleViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create service collection
            var services = Services.ApplicationServices.ConfigureServices();

            // Create service provider
            var serviceProvider = services.BuildServiceProvider();

            // Settings
            var configuration = serviceProvider.GetService<IConfiguration>();
        }
    }
}
