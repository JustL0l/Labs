//15 вариант, средний уровень

Console.WriteLine("введите строку:");
string text=Console.ReadLine()!;
for (int i = text.Length - 1; i >= 0; i--)
{
    if (text[i] == ' ')
    {
        text = text.Remove(i, 1);
        break;
    }
}
Console.WriteLine(text);

