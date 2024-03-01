namespace SumConsecutives
{
    internal class Program
    {
        static void print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
        }
        static int[] sumConsecutives(int[] numbers)
        {
            List<int> resultArray = new List<int>();

            for (int i = 1; i < numbers.Length; i++)
            {
                int previousElement = i - 1;
                int sum = numbers[previousElement];
                while (numbers[previousElement] == numbers[i])
                {
                    sum += numbers[i];
                    i++;
                    previousElement++;
                }
                i--;
                previousElement--;
                resultArray.Add(sum);
            }


            return resultArray.ToArray();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] numbers = { 1, 2, 3, 3, 4 };

            int[] output = sumConsecutives(numbers);
            print(output);
        }
    }
}
