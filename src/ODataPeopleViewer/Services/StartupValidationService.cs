using Microsoft.Extensions.Configuration;
using ODataPeopleViewer.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataPeopleViewer.Services
{
    public interface IStartupValidationService
    {
        public StartupValidationResponse PerformStartupValidations();
    }

    public class StartupValidationService : IStartupValidationService
    {
        private readonly string _serviceRoot;

        public StartupValidationService(IConfiguration configuration)
        {
            _serviceRoot = configuration["Odata:BaseUrl"];
        }

        public StartupValidationResponse PerformStartupValidations()
        {
            var response = new StartupValidationResponse()
            {
                ValidationsPassed = true,
            };

            if (string.IsNullOrWhiteSpace(_serviceRoot))
            {
                response.ValidationsPassed = false;
                response.ErrorMessage = "Base URL is null. Please add it to the appsettings file.";
                return response;
            }

            return response;
        }
    }
}
