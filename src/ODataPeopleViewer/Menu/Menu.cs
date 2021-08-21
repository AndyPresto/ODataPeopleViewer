using ODataPeopleViewer.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODataPeopleViewer.OData.Model;

namespace ODataPeopleViewer.Menu
{
    public interface IMenuLogic
    {
        /// <summary>
        /// Shows the main menu of the application.
        /// </summary>
        public Task<bool> ShowMainMenu();
    }

    public class MenuLogic : IMenuLogic
    {
        private readonly IOData _oData;
        private readonly IMenuPrintingService _menuPrinting;
        private int _page = 0;

        public MenuLogic(IOData oData, IMenuPrintingService menuPrinting)
        {
            _oData = oData;
            _menuPrinting = menuPrinting;
        }

        public async Task<bool> ShowMainMenu()
        {
            Console.Clear();

             await ShowPeopleOnScreen();

            Console.WriteLine("Choose an option:");
            Console.WriteLine("+) Next page");
            Console.WriteLine("-) Previous page");
            Console.WriteLine("x) Exit");
            Console.WriteLine("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "x":
                    return false;
                default:
                    return true;
            }
        }

        private async Task ShowPeopleOnScreen()
        {
            var peopleResponse = await _oData.GetPeople(new GetPeopleRequest());
            _menuPrinting.PrintPersonsToConsole(new Model.PrintPersonsToConsoleRequest
            {
                Persons = peopleResponse.People
            });
            Console.WriteLine("\r\n");
        }
    }
}
