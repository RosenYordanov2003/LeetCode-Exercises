int n = int.Parse(Console.ReadLine());
PrintNumbers(n, 0);

static void PrintNumbers(int number, int current)
{
    if(current >= number)
    {
        return;
    }
    Console.Write($"{++current} ");
    PrintNumbers(number, current);
}