using System;
using System.Collections.Generic;

namespace WeekDay
{
    class WeekDay
    {
        static void Main(string[] args)
        {
            /*Dictionary<int, string> week = new Dictionary<int, string>(7);
            week.Add(1, "Monday");
            week.Add(2, "Tuesday");
            week.Add(3, "Wednesday");
            week.Add(4, "Thursday");
            week.Add(5, "Friday");
            week.Add(6, "Saturday");
            week.Add(7, "Sunday");
            
            Console.WriteLine("Enter number of the day of the week:");
            int weekDayNum = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(weekDayNum + " - " + week[weekDayNum]);
            Console.ReadLine();
            */

            string[] week = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            Console.Write("Введите номер дня недели: ");
            int weekDayNum = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            Console.WriteLine(weekDayNum + " - " + week[weekDayNum-1]);
            Console.ReadLine();
        }
    }
}
