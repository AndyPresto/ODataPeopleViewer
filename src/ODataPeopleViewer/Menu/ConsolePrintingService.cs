using Microsoft.OData.SampleService.Models.TripPin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODataPeopleViewer.Menu.Model;

namespace ODataPeopleViewer.Menu
{
    public interface IMenuPrintingService
    {
        public void PrintPersonsToConsole(PrintPersonsToConsoleRequest request);
    }

    public class MenuPrintingService : IMenuPrintingService
    {
        public void PrintPersonsToConsole(PrintPersonsToConsoleRequest request)
        {
            if (request == null || request.Persons == null || request.Persons.Count == 0)
                return;

            foreach (var person in request.Persons)
            {
                Console.WriteLine(person.UserName);
            }
        }
    }
}
