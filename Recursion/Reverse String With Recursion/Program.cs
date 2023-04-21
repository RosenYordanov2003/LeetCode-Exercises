string text = Console.ReadLine();
int index = 0;
Console.WriteLine(GetReversedString(text, index));
string GetReversedString(string text, int index)
{
    if(index == text.Length)
    {
        return "";
    }
    else
    {
        return text[text.Length - 1 - index] + GetReversedString(text, index + 1);
    }
}