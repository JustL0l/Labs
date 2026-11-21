string[] cabinetNames = { "терапевт", "хирург", "флюорография" };
int[] cabinetNumbers = { 101, 205, 112 };
string[] doctors = { "Иванов И.И.", "Петров П.П.", "Сидорова А.А." };
string[] days = {
    "понедельник - вторник",
    "среда - четверг",
    "пятница - суббота"
};
DateTime[] startTimes = {
    DateTime.Parse("08:00"),
    DateTime.Parse("09:30"),
    DateTime.Parse("10:00")
};
DateTime[] endTimes = {
    DateTime.Parse("14:00"),
    DateTime.Parse("15:30"),
    DateTime.Parse("16:00")
};

Console.WriteLine("список всех записей");
for (int i = 0; i < cabinetNames.Length; i++)
{
    TimeSpan duration = endTimes[i] - startTimes[i];
    Console.WriteLine($"кабинет: {cabinetNames[i]} (#{cabinetNumbers[i]}) | врач: {doctors[i]} | день: {days[i]} | время: {startTimes[i]:HH:mm} - {endTimes[i]:HH:mm} | длительность: {duration}");
}

Console.WriteLine("\nпроверка работы кабинета флюорографии");
Console.Write("введите день недели: (1-понедельник, 7-воскресенье) ");
string searchDay = Console.ReadLine();

Console.Write("введите время (чч:мм): ");
DateTime searchTime = DateTime.Parse(Console.ReadLine());

for (int i = 0; i < cabinetNames.Length; i++)
{
    if (cabinetNames[i] == "флюорография")
    {
        char startDay = days[i][0];
        char endDay = days[i].Split(" - ")[1][0];

        if (searchDay[0] >= startDay && searchDay[0] <= endDay)
        {
            if (searchTime >= startTimes[i] && searchTime <= endTimes[i])
            {
                Console.WriteLine("кабинет флюорографии может принять в это время.");
                return;
            }
        }
    }
}
Console.WriteLine("кабинет флюорографии не может принять в это время");
