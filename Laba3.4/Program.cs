// 6 вариант, средний уровень

double h = 0.5;
Console.WriteLine("|      x      |      y      |");
Console.WriteLine("-----------------------------");
for (double x = -1; x <= 15; x += h)
{
    double y;
    if (x > 3.8) y = Math.Log(Math.Abs(1 + x));
    else if (x >= 2.8 && x <= 3.8) y = Math.Exp(-x);
    else y = Math.Cos(x);

    Console.WriteLine($"|   {x:f1}   |   {y:f2}   |");
    Console.WriteLine("-----------------------------");
}
