using KaladynskayaDaryaCSharp.Tasks;
using static KaladynskayaDaryaCSharp.Constants.MenuKeys;

namespace KaladynskayaDaryaCSharp.Menu
{
    public class ConsoleMenuManager
    {
        public static void CheckChoiceAndRun(int actions)
        {
            var consoleMenu = new ConsoleMenu();
            try
            {
                switch (actions)
                {
                    case (int)MenuItems.Task1CheckNumber:
                        Console.WriteLine("Enter your number");
                        var userNumber = Convert.ToInt32(Console.ReadLine());
                        var checkNumber = new CheckNumber(userNumber);
                        checkNumber.CheckIsNumber7();
                        consoleMenu.ShowMenu();
                        break;
                    case (int)MenuItems.Task2NameCheck:
                        Console.WriteLine("Enter name");
                        var userName = Console.ReadLine();
                        var checkName = new ChecName(userName);
                        Console.WriteLine(checkName.CheckIsNameVyacheslav());
                        consoleMenu.ShowMenu();
                        break;
                    case (int)MenuItems.ArrayTask:
                        var arrayTask = new ArrayTask();
                        ArrayTask.CheckArray();
                        consoleMenu.ShowMenu();
                        break;
                    case (int)MenuItems.Exit:
                        Environment.Exit(0);
                        break;
                    default:
                        consoleMenu.ShowMenu();
                        break;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                consoleMenu.ShowMenu();
            }
        }
    }
}
