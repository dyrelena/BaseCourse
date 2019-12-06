using System;

namespace Average
{
    class AverageRandom
    {
        static void Main(string[] args)
        {
            int arrSize = 5;
            long[] nums = new long[arrSize];
            long sum = 0;
            Random rnd = new Random();
            long value;

            for (int j = 0; j < arrSize; j++)
            {
                value = rnd.Next();
                nums[j] = value;
            }

            foreach (int j in nums)
            {
                Console.WriteLine(j);
            }

            for (int j = 0; j < arrSize; j++)
            {
                sum += nums[j];
            }

            Console.WriteLine("Среднее арифметическое = " + sum / arrSize);
            Console.ReadLine();
        }
    }
}
