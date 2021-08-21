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
        private readonly int _tableWidth = 90;

        public void PrintPersonsToConsole(PrintPersonsToConsoleRequest request)
        {
            if (request == null || request.Persons == null || request.Persons.Count == 0)
                return;

            PrintRow("Username", "First Name", "Last Name", "Email");
            PrintRow("", "", "", "");
            PrintRow("", "", "", "");

            foreach (var person in request.Persons)
            {
                PrintRow(person.UserName, person.FirstName, person.LastName, person.Emails?.FirstOrDefault() ?? "");
            }
        }

        private void PrintRow(params string[] columns)
        {
            int width = (_tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        private string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
