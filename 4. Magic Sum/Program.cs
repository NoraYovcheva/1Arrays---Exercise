namespace _4._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();
            int controlNumber = int.Parse(Console.ReadLine());

            for (int elements = 0; elements < array.Length; elements++)
            {
                int currentNumber = array[elements];

                for (int i = elements + 1; i < array.Length; i++)
                {
                    int rightNumber = array[i];

                    if (currentNumber + rightNumber == controlNumber)
                    {
                        Console.WriteLine($"{currentNumber} {rightNumber}");
                    }
                }
            }
        }
    }
}
