int n = int.Parse(Console.ReadLine());
PrintNumbers(n);

static void PrintNumbers(int number)
{
    if (number == 0)
    {
        return;
    }
    Console.Write($"{number} ");
    PrintNumbers(number - 1);
}