Console.Write("введите количество товаров: ");
int n = int.Parse(Console.ReadLine()!);
Product[] products = new Product[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\nТовар №{i + 1}:");
    Console.Write("название товара: ");
    products[i].Name = Console.ReadLine()!;

    Console.Write("цена: ");
    products[i].Price = double.Parse(Console.ReadLine()!);

    Console.Write("дата производства (дд.мм.гггг): ");
    products[i].ProductionDate = DateTime.Parse(Console.ReadLine()!);

    Console.Write("срок годности (в днях): ");
    products[i].ShelfLife = int.Parse(Console.ReadLine()!);

    Console.Write("количество: ");
    products[i].Quantity = int.Parse(Console.ReadLine()!);
}
DateTime today = DateTime.Now;
int expiredCount = 0;
Console.WriteLine("\nтовары со сроком годности менее 20 дней:");
foreach (var p in products)
{
    if (p.ShelfLife < 20)
        Console.WriteLine($"{p.Name} — цена: {p.Price} | дата: {p.ProductionDate:dd.MM.yyyy} | срок: {p.ShelfLife} дн. | кол-во: {p.Quantity}");

    if (p.ProductionDate.AddDays(p.ShelfLife) < today)
        expiredCount++;
}
Console.WriteLine($"\nколичество просроченных товаров: {expiredCount}");
struct Product
{
    public string Name;
    public double Price;
    public DateTime ProductionDate;
    public int ShelfLife;
    public int Quantity;
}
