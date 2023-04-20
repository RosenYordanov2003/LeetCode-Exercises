string text = Console.ReadLine();
int index = 0;
Console.WriteLine(CheckIsPalindrome(text, index));

bool CheckIsPalindrome(string text, int index)
{
    if(index == text.Length - 1)
    {
        return true;  
    }
    if (text[index] != text[text.Length - 1 - index])
    {
        return false;
    }
    return CheckIsPalindrome(text, index + 1);
}