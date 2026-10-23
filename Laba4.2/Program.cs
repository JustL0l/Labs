Random rnd = new Random();
Console.Write("введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);

int[,] mas = new int[n, m];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = rnd.Next(1, 10);
        Console.Write($"{mas[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int max = 0;

for (int j = 0; j < mas.GetLength(1); j++)
{
    int k1 = 1;
    int k2 = 1;

    for (int i = 1; i < mas.GetLength(0); i++)
    {
        if (mas[i - 1, j] <= mas[i, j]) k1++;
        if (mas[i - 1, j] >= mas[i, j]) k2++;
    }

    if (k1 == mas.GetLength(0) || k2 == mas.GetLength(0))
    {
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            int temp = mas[i, j];
            if (temp > max)
            {
                max = temp;
            }
        }
    }
}
Console.WriteLine(max);
