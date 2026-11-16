//18 вариант, сложный уровень//

Console.Write("введите количество чисел n: ");
int n = int.Parse(Console.ReadLine()!);

int[] mas = new int[n];
Console.WriteLine($"введите {n} различных чисел:");
for (int i = 0; i < n; i++)
{
    mas[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < n - 1 - i; j++)
    {
        if (mas[j] > mas[j + 1])
        {
            int temp = mas[j];
            mas[j] = mas[j + 1];
            mas[j + 1] = temp;
        }
    }
}

Console.WriteLine("\nвсевозможные перестановки:");

while (true)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(mas[i] + " ");
    }
    Console.WriteLine();

    int k = n - 2;
    while (k >= 0 && mas[k] >= mas[k + 1])
    {
        k--;
    }

    if (k < 0) break;

    int l = n - 1;
    while (mas[k] >= mas[l])
    {
        l--;
    }

    int temp = mas[k];
    mas[k] = mas[l];
    mas[l] = temp;

    int left = k + 1;
    int right = n - 1;
    while (left < right)
    {
        temp = mas[left];
        mas[left] = mas[right];
        mas[right] = temp;
        left++;
        right--;
    }
}
