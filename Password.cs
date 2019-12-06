using System;
using System.Threading;

namespace Password
{
    class Password
    {
        static void Main(string[] args)
        {
            const string  pass = "root";
            string answer;
            bool access = false;

            do
            {
                Console.WriteLine("Пароль?");
                answer = Console.ReadLine();

                if (pass == answer)
                {
                    access = true;
                }
                else
                {
                    Console.WriteLine("Неверный пароль! \n");                    
                    Thread.Sleep(800);
                    Console.Clear();
                }
            } while (access == false);

            Console.Clear();
            Console.WriteLine("Доступ разрешен!");
            Console.ReadLine();
        }
    }
}
