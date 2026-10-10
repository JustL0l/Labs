// 6 вариант

try
{
    Console.Write("введите n:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("введите x:");
    double x = double.Parse(Console.ReadLine());
    double s = 1;
    for (int i = 1; i <= n; i++)
    {
        double f = 1;
        for (int m = 1; m <= i; m++)
        {
            f *= m;
        }
        s += (Math.Cos(i * Math.PI / 4) / f) * Math.Pow(x, i);
    }
    Console.WriteLine($"s={s:f2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

