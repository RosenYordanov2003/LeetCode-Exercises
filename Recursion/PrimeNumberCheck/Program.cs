int number = int.Parse(Console.ReadLine());
int divider = number - 1;
bool result = true;
Console.WriteLine(CheckIsPrime(number, divider, result));

static bool CheckIsPrime(int number, int divider, bool isPrime)
{
    if (divider == 1)
    {
        return isPrime;
    }
    if(number % divider == 0)
    {
        isPrime = false;
        return isPrime;
    }
    else
    {
       return CheckIsPrime(number, divider - 1, isPrime);
    }
}