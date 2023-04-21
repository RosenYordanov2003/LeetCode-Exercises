int numOne = int.Parse(Console.ReadLine());
int numTwo = int.Parse(Console.ReadLine());
Console.WriteLine(FindGCD(numOne, numTwo));

int FindGCD(int num1, int num2)
{
    if (num2 == 0)
    {
        return num1;
    }
    else
    {
        return FindGCD(num2, num1 % num2);
    }
}