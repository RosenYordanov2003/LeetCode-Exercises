int range = int.Parse(Console.ReadLine());
List<int> evenNumbers = new List<int>();
List<int> oddNumbers = new List<int>();
int current = 1;
GetEvenAndOddNumbers(range, current);
PrintNumbers(evenNumbers, oddNumbers);


void GetEvenAndOddNumbers(int range, int current)
{
    if (current > range)
    {
        return;
    }
    if (current % 2 == 0)
    {
        evenNumbers.Add(current);
    }
    else
    {
        oddNumbers.Add(current);
    }
    GetEvenAndOddNumbers(range, current + 1);

}
void PrintNumbers(List<int> evenNumbers, List<int> oddNumbers)
{
    Console.WriteLine("Even numbers:");
    Console.Write(string.Join(' ', evenNumbers) + "\n");
    Console.WriteLine("Odd numbers: ");
    Console.Write(string.Join(' ', oddNumbers));
}