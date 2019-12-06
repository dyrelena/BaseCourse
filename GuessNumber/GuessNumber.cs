using System;
using System.Collections.Generic;

namespace GuessNumber
{
    class GuessNumber
    {       
        static int EnteredNumCheck(int guess, int numMin, int numMax)
        {
            do
            {
                if (guess < numMin)
                {
                    Console.WriteLine("{0} < {1}. Введите другое число", guess, numMin);
                    guess = Convert.ToInt32(Console.ReadLine());
                    counter++;
                }
                else if (guess > numMax)
                {
                    Console.WriteLine("{0} > {1}. Введите другое число", guess, numMax);
                    guess = Convert.ToInt32(Console.ReadLine());
                    counter++;
                }
            } while (guess < numMin || guess > numMax);
            return guess;
        }

        static int counter = 1;

        static void Main(string[] args)
        {
            Random num = new Random();
            int numMin = 1;
            int numMax = 146;
            int value = num.Next(numMin, numMax);
            int guess;
                        
                Console.WriteLine("Какое число от {0} до {1} я загадал?", numMin, numMax);
                guess = Convert.ToInt32(Console.ReadLine());

                guess = EnteredNumCheck(guess, numMin, numMax);
                
                do
                {                
                    if (guess > value)
                        {
                            Console.WriteLine("Меньше");
                        }
                    else if (guess < value)
                {
                            Console.WriteLine("Больше");
                        }
                    guess = Convert.ToInt32(Console.ReadLine());
                    guess = EnteredNumCheck(guess, numMin, numMax);
                    counter++;

                } while (guess != value);

                Console.WriteLine("Бинго! \nУгадал, {0} за {1} попыток", value, counter);
                Console.ReadLine();                
            }
    }
}
