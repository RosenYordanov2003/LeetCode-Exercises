int number = int.Parse(Console.ReadLine());
int result = CalcFactorial(number);
Console.WriteLine(result);
int CalcFactorial(int number)
{
    if(number == 1)
    {
        return 1;
    }
    return number * CalcFactorial(number - 1);
}