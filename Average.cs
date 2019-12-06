using System;

namespace Average
{
    class Average
    {
        static void Main(string[] args)
        {
            int arrSize = 5;
            int[] nums = new int[arrSize];
            int sum = 0;
            Random rnd = new Random();
            int value;
            
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


            Console.Clear();
            Console.WriteLine("Среднее арифметическое = " + sum/arrSize);
            Console.ReadLine();
        }
    }
}
