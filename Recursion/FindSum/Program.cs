int n = int.Parse(Console.ReadLine());

int result = FindSum(n);
Console.WriteLine(result);

int FindSum(int n)
{
    if(n == 0)
    {
        return 0;
    }
   return n + FindSum(n - 1);
}