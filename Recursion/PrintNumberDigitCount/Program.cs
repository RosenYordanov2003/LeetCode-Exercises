int number = int.Parse(Console.ReadLine());
int counter = 0;
int result = GetNumberDigitsCount(number, counter);
Console.WriteLine(result);

int GetNumberDigitsCount(int number, int counter)
{
    if(number == 0)
    {
       return counter;
    }
    return GetNumberDigitsCount(number / 10, counter + 1);
}