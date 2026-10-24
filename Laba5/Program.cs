// 12 вариант, сложный уровень

try
{
    Console.WriteLine("введите строчку из 11 английских символов: ");
    string input = Console.ReadLine();

    char[] mas = new char[11];
    for (int i = 0; i < 11; i++)
    {
        mas[i] = input[i];
    }
    int key = 128;
    for (int i = 0; i < 11; i++)
    {
        mas[i] = (char)((int)mas[i] ^ key);
    }
    Console.Write("зашифрованный массив: ");
    for (int i = 0; i < 11; i++)
    {
        Console.Write(mas[i]);
    }
    Console.WriteLine();
    for (int i = 0; i < 11; i++)
    {
        mas[i] = (char)((int)mas[i] ^ key);
    }
    Console.Write("дешифрованный массив: ");
    for (int i = 0; i < 11; i++)
    {
        Console.Write(mas[i]);
    }
    Console.WriteLine();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


