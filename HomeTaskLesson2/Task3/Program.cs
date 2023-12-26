Console.WriteLine("Enter number from 10 to 99");
int num1 = int.Parse(Console.ReadLine()!);
int maxnum = 0;

if (num1 > 9 && num1 < 100)
{
    int last = num1 % 10;
    maxnum = Math.Max(last, maxnum);
    num1 /= 10;
    Console.WriteLine(maxnum);

}
else
{
    Console.WriteLine("incorrect number");
}
