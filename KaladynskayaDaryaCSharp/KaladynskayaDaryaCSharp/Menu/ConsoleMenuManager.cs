using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KaladynskayaDaryaCSharp.Constants.MenuKeys;
using static System.Formats.Asn1.AsnWriter;

namespace KaladynskayaDaryaCSharp.Menu
{
    public class ConsoleMenuManager
    {
        public static void CheckChoiceAndRun(int actions)
        {
            var consoleMenu = new ConsoleMenu();

            switch (actions)
            {
                case (int)MenuItems.Task1CheckNumber7:
                    var store = new Store();
                    store.ShowMenu(MenuItems.Store);
                    consoleMenu.ShowMenu();
                    break;
                case (int)MenuItems.Task2VyacheclavCheck:
                    var basket = new BasketMenu();
                    basket.ShowMenu(MenuItems.Basket);
                    consoleMenu.ShowMenu();
                    break;
                case (int)MenuItems.ArrayTask:
                    Profile profile = new Profile();
                    profile.ShowMenu(MenuItems.Profile);
                    consoleMenu.ShowMenu();
                    break;
                case (int)MenuItems.Exit:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
