namespace KaladynskayaDaryaCSharp.Tasks
{
    internal class ArrayTask
    {
        private static int[] ReadUserArray()
        {
            Console.Write("Enter array length: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter array items [" + i + "]: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nYour Array:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            return numbers;
        }

        public static void CheckArray()
        {
            var userArray = ReadUserArray();
            Console.WriteLine("\nElements of the array that are divisible by 3:");

            for (int i = 0; i < userArray.Length; i++)
            {
                if (userArray[i] % 3 == 0)
                {
                    Console.WriteLine(userArray[i]);
                }
            }
        }
    }
}
