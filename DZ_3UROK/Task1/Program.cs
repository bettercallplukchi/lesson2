// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.



using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("enter value or 'q' : ");
            string input = Console.ReadLine();

            if (input == "q")
            {
                break;

            }

            int number;
            if (int.TryParse(input, out number))
            {
                int sum = sum_numbers(number);

                if (sum % 2 == 0)
                {
                    break;
                }

            }
            else
            {
                Console.WriteLine("enter value or 'q' : ");
            }

        }

        Print("end of cycle. Summa numbers even or enter 'q'");
    }
    static void Print(string res)
    {
        Console.WriteLine(res);
    }

    static int sum_numbers(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
