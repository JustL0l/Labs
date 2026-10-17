try
{
    Console.Write("введите n: ");
    int n = int.Parse(Console.ReadLine());

    Random rnd = new Random();
    int[] mas = new int[n];

    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = rnd.Next(-19, 27);
        Console.Write($"{mas[i]} ");
    }
    Console.WriteLine();

    long product = 1;
    bool hasOddIndices = false;

    for (int i = 1; i < mas.Length; i += 2)
    {
        product *= mas[i];
        hasOddIndices = true;
    }

    if (hasOddIndices)
    {
        Console.WriteLine($"произведение элементов с нечетными номерами = {product}");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
