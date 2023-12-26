//Задача 2: Напишите программу, которая принимает на вход координаты точки (Х и У),
// причём Х неравно 0 и У неравно О и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.WriteLine("Enter x and y");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine());

if (num1 > 0 && num2 > 0)
{
    Console.WriteLine("You are in the first part");
}
else if (num1 < 0 && num2 > 0)
{
    Console.WriteLine("You are in the second part");
}
else if (num1 < 0 && num2 < 0)
{
    Console.WriteLine("You are in the third part");
}
else if (num1 > 0 && num2 < 0)
{
    Console.WriteLine("You are in the fourth part");
}

