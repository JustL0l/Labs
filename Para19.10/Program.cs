/*Random rnd = new Random();
int[,] mas = new int[4, 4];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = rnd.Next(-5, 6);
        Console.Write($"{mas[i, j]} ");
    }
    Console.WriteLine();
}
int min = mas[0, 0];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (mas[i, j] < min) min = mas[i, j];
    }

}
Console.WriteLine();
Console.WriteLine($"{min}");
Console.WriteLine();
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (mas[i, j] % 2 == 0) mas[i, j] *= 2;
        else mas[i, j] *= 3;
        Console.Write($"{mas[i, j]} ");
    }
    Console.WriteLine();
}
*/

Random rnd = new Random();
int n = rnd.Next(3, 10);
int[,] mas = new int[n, n];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = rnd.Next(-3,4);
        Console.Write($"{mas[i, j]} ");
    }
    Console.WriteLine();
}
double S = 0;
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if(i==j) S+= mas[i, j];
    }
}
Console.WriteLine($"{S / mas.GetLength(0):F2}");
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (mas[i, j] < 0) S += mas[i, j] = Math.Abs(mas[i, j]);
        Console.Write($"{mas[i,j]}");
    }
    Console.WriteLine();
}
S = 0;
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (i == j) S += mas[i, j];
    }
}
Console.WriteLine($"{S / mas.GetLength(0):F2}");
