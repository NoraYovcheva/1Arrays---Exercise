namespace _7._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                bool isBigger = true;
                int currentNumber = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    int rightNumber = array[j];

                    if (currentNumber <= rightNumber)
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger)
                {
                    Console.Write(currentNumber + " ");
                }
            }
            Console.WriteLine(array[array.Length - 1]);
        }
    }
}
