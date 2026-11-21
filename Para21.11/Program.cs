using System;

struct Product
{
    public string Name;           // Наименование
    public decimal Price;         // Цена
    public DateTime ManufactureDate; // Дата производства
    public int ShelfLifeDays;     // Срок годности (в днях)
    public int Quantity;          // Количество
    public string Manufacturer;   // Производитель
}

class Program
{
    static void Main()
    {
        Product[] products = {
            new Product {
                Name = "Молоко",
                Price = 85.50m,
                ManufactureDate = DateTime.Now.AddDays(-5),
                ShelfLifeDays = 10,
                Quantity = 20,
                Manufacturer = "Молочный завод №1"
            },
            new Product {
                Name = "Хлеб",
                Price = 45.00m,
                ManufactureDate = DateTime.Now.AddDays(-6),
                ShelfLifeDays = 5, // Просрочен (прошло 6 дней при сроке 5)
                Quantity = 15,
                Manufacturer = "Хлебокомбинат"
            },
            new Product {
                Name = "Консервы",
                Price = 150.00m,
                ManufactureDate = DateTime.Now.AddDays(-30),
                ShelfLifeDays = 365,
                Quantity = 50,
                Manufacturer = "Рыбпром"
            },
            new Product {
                Name = "Йогурт",
                Price = 60.00m,
                ManufactureDate = DateTime.Now.AddDays(-20),
                ShelfLifeDays = 14, // Просрочен (прошло 20 дней при сроке 14)
                Quantity = 10,
                Manufacturer = "Данон"
            }
        };

        Console.WriteLine("Список всех товаров:");
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"Товар: {products[i].Name} | Цена: {products[i].Price} руб. | Дата пр-ва: {products[i].ManufactureDate:dd.MM.yyyy} | Срок годности: {products[i].ShelfLifeDays} дн. | Кол-во: {products[i].Quantity} | Производитель: {products[i].Manufacturer}");
        }

        Console.WriteLine("\nТовары со сроком годности менее 20 дней:");
        int expiredCount = 0;

        for (int i = 0; i < products.Length; i++)
        {
            // 1. Выводим сведения о товарах, срок годности которых менее 20 дней
            if (products[i].ShelfLifeDays < 20)
            {
                Console.WriteLine($"- {products[i].Name} (Срок: {products[i].ShelfLifeDays} дн., Производитель: {products[i].Manufacturer})");
            }

            // 2. Определяем количество просроченных товаров
            DateTime expirationDate = products[i].ManufactureDate.AddDays(products[i].ShelfLifeDays);
            if (DateTime.Now > expirationDate)
            {
                expiredCount++; // Или expiredCount += products[i].Quantity, если нужно посчитать штуки
            }
        }

        Console.WriteLine($"\nКоличество просроченных наименований товаров: {expiredCount}");
    }
}
