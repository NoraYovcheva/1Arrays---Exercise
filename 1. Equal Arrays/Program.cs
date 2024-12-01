namespace _1._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberOne = Console.ReadLine()
                             .Split(" ")
                             .Select(int.Parse)
                             .ToArray();
            int[] numberTwo = Console.ReadLine()
                             .Split(" ")
                             .Select(int.Parse)
                             .ToArray();

            bool isIdentical = true;

            for (int i = 0; i <= numberOne.Length - 1; i++)
            {
                if (numberOne[i] != numberTwo[i])
                {
                    isIdentical = false;
                    Console.WriteLine("Arrays are not identical.");
                    break;
                }
            }
            if (isIdentical)
            {
                Console.WriteLine("Arrays are identical.");
            }

        }
    }
}
