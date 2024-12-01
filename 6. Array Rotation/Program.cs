namespace _6._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();

            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation; i++)
            {
                int firstNumber = number[0];

                for (int j = 1; j < number.Length; j++)
                {
                    number[j - 1] = number[j];
                }
                number[number.Length - 1] = firstNumber;
            }
            Console.WriteLine(string.Join(" ", number));
        }
    }
}
