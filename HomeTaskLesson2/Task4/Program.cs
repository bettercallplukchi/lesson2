Console.WriteLine("Enter natural number - n");
int number = int.Parse(Console.ReadLine()!);

string numberStr = number.ToString();
string result = "";
for (int i = 0; i < numberStr.Length; i++)
{
    Console.Write(numberStr[i]);

    if (i < numberStr.Length - 1)
    {
        Console.Write(", ");
    }
}