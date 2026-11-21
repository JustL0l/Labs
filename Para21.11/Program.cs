using System;

Product[] products = {
    new Product { Name = "Молоко", Price = 85.50m, ManufactureDate = DateTime.Now.AddDays(-5), ShelfLifeDays = 10, Quantity = 20, Manufacturer = "Молочный завод №1" },
    new Product { Name = "Хлеб", Price = 45.00m, ManufactureDate = DateTime.Now.AddDays(-6), ShelfLifeDays = 5, Quantity = 15, Manufacturer = "Хлебокомбинат" },
    new Product { Name = "Консервы", Price = 150.00m, ManufactureDate = DateTime.Now.AddDays(-30), ShelfLifeDays = 365, Quantity = 50, Manufacturer = "Рыбпром" },
    new Product { Name = "Йогурт", Price = 60.00m, ManufactureDate = DateTime.Now.AddDays(-20), ShelfLifeDays = 14, Quantity = 10, Manufacturer = "Данон" }
};

Console.WriteLine("список всех товаров");
for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine($"товар: {products[i].Name} | цена: {products[i].Price} | дата пр-ва: {products[i].ManufactureDate:dd.MM.yyyy} | срок годности: {products[i].ShelfLifeDays} дн. | кол-во: {products[i].Quantity} | производитель: {products[i].Manufacturer}");
}

Console.WriteLine("\nтовары со сроком годности менее 20 дней");
int expiredCount = 0;

for (int i = 0; i < products.Length; i++)
{
    if (products[i].ShelfLifeDays < 20)
    {
        Console.WriteLine($"товар: {products[i].Name} | цена: {products[i].Price} | дата пр-ва: {products[i].ManufactureDate:dd.MM.yyyy} | срок годности: {products[i].ShelfLifeDays} дн. | кол-во: {products[i].Quantity} | производитель: {products[i].Manufacturer}");
    }

    if (DateTime.Now > products[i].ManufactureDate.AddDays(products[i].ShelfLifeDays))
    {
        expiredCount++;
    }
}

Console.WriteLine($"\nколичество просроченных товаров: {expiredCount}");

struct Product
{
    public string Name;
    public decimal Price;
    public DateTime ManufactureDate;
    public int ShelfLifeDays;
    public int Quantity;
    public string Manufacturer;
}
