int number = int.Parse(Console.ReadLine());
int index = 0;
PrintNumberDigits(number, index);
static void PrintNumberDigits(int number, int index)
{
    if (index == number.ToString().Length)
    {
        return;
    }
    char firstDigit = number.ToString()[index++];
    Console.Write($"{firstDigit} ");
    PrintNumberDigits(number, index);
}