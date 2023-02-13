using KaladynskayaDaryaCSharp.Constants;
using System.Text;

namespace KaladynskayaDaryaCSharp.Menu
{
    internal class ConsoleMenu
    {
        private static int _userChoice;
        private int indexChoice = 1;

        public void ShowMenu()
        {
            try
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Please enter a number to choose your action");
                var stringBuilderMenu = new StringBuilder();

                foreach (MenuKeys.MenuItems item in Enum.GetValues(typeof(MenuKeys.MenuItems)))
                {
                    stringBuilderMenu.Append(indexChoice++ + " - " + item.GetEnumDescription() + "\n");
                }

                Console.WriteLine(stringBuilderMenu.ToString());
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                _userChoice = Convert.ToInt32(Console.ReadLine());
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"IndexOutOfRangeException: Wrong case number, select from 1 to {Enum.GetValues(typeof(MenuKeys.MenuItems)).Length}");
                ShowMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ShowMenu();
            }
        }
    }
}

