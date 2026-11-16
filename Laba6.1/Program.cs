using test;

double[,] mas = new double[8, 9];
Console.WriteLine("матрица 8x9:");
for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 9; j++)
    {
        mas[i, j] = Math.Pow(Math.Log(9 * (i + 1) + (j + 1), 3), 3) + Math.Pow(-Math.E, i + 1);
        Console.Write($"{mas[i, j],9:F2}");
    }
    Console.WriteLine();
}

int maxj = 0;
double maxsum = double.MinValue;
for (int j = 0; j < 9; j++)
{
    double sum = 0;
    for (int i = 0; i < 8; i++) sum += mas[i, j];
    if (sum > maxsum)
    {
        maxsum = sum;
        maxj = j;
    }
}

Console.WriteLine($"\nвектор (столбец №{maxj + 1} с макс. суммой {maxsum:F2}):");
double[] vec = new double[8];
for (int i = 0; i < 8; i++)
{
    vec[i] = mas[i, maxj];
    Console.Write($"{vec[i]:F2}  ");
}

Console.WriteLine($"\n\nсумма элементов вектора с четными индексами: {OurClassLibrary.SumEven(vec):F2}");
