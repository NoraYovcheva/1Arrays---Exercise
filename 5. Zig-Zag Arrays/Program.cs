namespace _5._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrayOne = new int [n];
            int[] arrayTwo = new int [n];

            for (int i = 0; i < n; i++)
            {
                int[] rows = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToArray();

                int firstNumber = rows [0];
                int secondNumber = rows [1];

                if (i % 2 == 0)
                {
                    arrayOne[i] = firstNumber;
                    arrayTwo[i] = secondNumber;
                }
                else
                {
                    arrayOne [i] = secondNumber;
                    arrayTwo [i] = firstNumber;
                }
            }
            Console.WriteLine(string.Join(" ", arrayOne));
            Console.WriteLine(string.Join(" ",  arrayTwo));
        }
    }
}
