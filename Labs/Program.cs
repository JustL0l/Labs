//сложный уровень, 6 вариант

int sum = 0;
int number = 0;

Console.WriteLine("введите последовательность чисел: ");

do
{
    try
    {
        number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            sum += number;
        }
    }
    catch
    {
        Console.WriteLine("не то ввёл");
        number = -1;
    }
} while (number != 0);

Console.WriteLine($"результат: {sum}");
