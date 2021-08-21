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
        private int _page = 0;

        public MenuLogic(IOData oData)
        {
            _oData = oData;
        }

        public async Task<bool> ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("+) Next page");
            Console.WriteLine("-) Previous page");
            Console.WriteLine("x) Exit");
            Console.WriteLine("\r\nSelect an option: ");
            var people = await _oData.GetPeople(new GetPeopleRequest());

            switch (Console.ReadLine())
            {
                case "+":
                    return true;
                case "-":
                    return true;
                case "x":
                    return false;
                default:
                    return true;
            }
        }
    }
}
