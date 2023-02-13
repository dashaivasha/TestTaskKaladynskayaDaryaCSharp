namespace KaladynskayaDaryaCSharp.Tasks
{
    public class CheckNumber
    {
        public int UserNumber;

        public CheckNumber(int userNumber)
        {
            UserNumber = userNumber;
        }

        public void CheckIsNumber7()
        {
            if (UserNumber > 7)
            {
                Console.WriteLine("Привет");
            }
        }
    }
}
