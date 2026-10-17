//12 уровень высокий уровень

int[] mas = new int[3];
Console.WriteLine("введите три числа: ");
for (int i = 0; i < 3; i++)
{
    mas[i] = int.Parse(Console.ReadLine());
}
if (mas[0] == mas[1])
{
    Console.WriteLine("одинаковые элементы: 1-й и 2-й");
}
else if (mas[0] == mas[2])
{
    Console.WriteLine("одинаковые элементы: 1-й и 3-й");
}
else if (mas[1] == mas[2])
{
    Console.WriteLine("одинаковые элементы: 2-й и 3-й");
}
else
{
    Console.WriteLine(" нет одинаковых элементов");
}
