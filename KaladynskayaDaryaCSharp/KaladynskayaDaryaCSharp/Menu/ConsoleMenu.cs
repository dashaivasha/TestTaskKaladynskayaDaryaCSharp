using KaladynskayaDaryaCSharp.Constants;
using System.Text;

namespace KaladynskayaDaryaCSharp.Menu
{
    internal class ConsoleMenu
    {
        private static int _userChoice;

        public void ShowMenu()
        {
            try
            {
                Console.WriteLine("Please enter a number to choose your action");
                var stringBuilderMenu = new StringBuilder();
                int indexChoice = 1;

                foreach (MenuKeys.MenuItems item in Enum.GetValues(typeof(MenuKeys.MenuItems)))
                {
                    stringBuilderMenu.Append(indexChoice++ + " - " + item.GetEnumDescription() + "\n");
                }

                Console.WriteLine(stringBuilderMenu.ToString());
                _userChoice = Convert.ToInt32(Console.ReadLine());

                ConsoleMenuManager.CheckChoiceAndRun(_userChoice);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ShowMenu();
            }
        }
    }
}

