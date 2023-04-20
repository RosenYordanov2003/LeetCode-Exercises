int number = int.Parse(Console.ReadLine());
int fib = CalculateFibonacci(number);
Console.WriteLine(fib);

int CalculateFibonacci(int number)
{
    if (number == 0 || number == 1)
    {
        return number;
    }
    else
    {
        return CalculateFibonacci(number - 1) + CalculateFibonacci(number - 2);
    }
}