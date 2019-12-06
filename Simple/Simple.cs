using System;

namespace Simple
{
    class Simple
    {
        static void Main(string[] args)
        {
            int num;
            String repeat;
            bool isSimple = false;
            do
            {
                Console.WriteLine("Введите целое положительное число:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine("Простое");
                }
                else
                {
                    for (int i = 2; i <= (num / 2); i++)
                    {
                    int j = num % i;
                    if (j == 0)
                        {
                            isSimple = false;
                        break;
                        }
                        else
                        {
                            isSimple = true;
                        }
                    }

                   if (isSimple)
                    {
                        Console.WriteLine("Простое");
                    }
                    else
                    {
                        Console.WriteLine("Составное");
                    }
                }
                Console.WriteLine("Продолжить? y/n");
            repeat = Console.ReadLine();
        } while (repeat == "y");
        }
    }
}
