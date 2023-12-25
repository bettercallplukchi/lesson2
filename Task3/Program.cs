int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);

if (n % m == 0)
{
    Console.WriteLine("CRATNO");
}
else
{
    Console.WriteLine("NECRATNO " + n % m);
}

