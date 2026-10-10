// 6 вариант, средний уровень ( высокого нет )

try
{
    Console.Write("введите k: ");
    int k = int.Parse(Console.ReadLine());
    double W = 0;
    for (int i = -2; i <= k; i++)
    {
        if (i == 4) continue;
        double f = 1;
        for (int m = 1; m <= i + 3; m++)
        {
            f *= m;
        }
        W += Math.Pow(-1, i) * f / (i - 4.0);
    }
    Console.WriteLine($"W={W:F2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
