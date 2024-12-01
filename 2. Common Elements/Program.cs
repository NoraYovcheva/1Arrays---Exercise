namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine()
                             .Split(" ")
                             .Select(int.Parse)
                             .ToArray();
            int[] arrayTwo = Console.ReadLine()
                             .Split(" ")
                             .Select(int.Parse)
                             .ToArray();

            foreach (int elements1 in arrayOne)
            {
                foreach (int elements2 in arrayTwo)
                {
                    if (elements1 == elements2)
                    {
                        Console.Write(elements1 + " ");
                    }
                }
            }
        }
    }
}
