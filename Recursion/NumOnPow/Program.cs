int number = int.Parse(Console.ReadLine());
int pow = int.Parse(Console.ReadLine());
int result = CalculateNumOnPow(number, pow);
Console.WriteLine(result);
int CalculateNumOnPow(int number, int pow)
{
    if (pow == 0)
    {
        return 1;
    }
    return number * CalculateNumOnPow(number, pow - 1);
}