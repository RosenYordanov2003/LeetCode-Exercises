int numberOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());
int start = numberOne * numberTwo;
int result = 0;

if (numberOne <= 0 || numberTwo <= 0)
{
    Console.WriteLine("Number must be greater than zero");
    return;
}

Console.WriteLine(FindLCM(numberOne, numberTwo, start));

int FindLCM(int numberOne, int numberTwo, int start)
{
    if (start < numberOne || start < numberTwo)
    {
        return result;
    }
    else
    {
        if (start % numberOne == 0 && start % numberTwo == 0)
        {
            result = start;
        }
        return FindLCM(numberOne, numberTwo, start - 1);
    }
}