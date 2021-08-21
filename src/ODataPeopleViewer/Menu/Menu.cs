using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataPeopleViewer.Menu
{
    public interface IMenuLogic
    {
        /// <summary>
        /// Shows the main menu of the application.
        /// </summary>
        public bool ShowMainMenu();
    }

    public class MenuLogic : IMenuLogic
    {
        public MenuLogic()
        {

        }

        public bool ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("+) Next page");
            Console.WriteLine("-) Previous page");
            Console.WriteLine("x) Exit");
            Console.WriteLine("\r\nSelect an option: ");

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
