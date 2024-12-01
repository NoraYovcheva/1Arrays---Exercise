namespace _3._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]numbers = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();

            while (numbers.Length > 1)
            {
                int[] number = new int[numbers.Length - 1];

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int sum = numbers[i] + numbers[i + 1];
                    number[i] = sum;
                }
                numbers = number;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
