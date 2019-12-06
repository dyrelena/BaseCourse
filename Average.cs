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
            Console.WriteLine("Введите {0} чисел:", arrSize);
            int value;
            
            for (int j = 0; j < arrSize; j++)
            {
                value = Convert.ToInt32(Console.ReadLine());
                nums[j] = value;
            }

            for (int j = 0; j < arrSize; j++)
            {
                sum += nums[j];
            }
                                   
            Console.WriteLine("Среднее арифметическое = " + sum/arrSize);
            Console.ReadLine();
        }
    }
}
