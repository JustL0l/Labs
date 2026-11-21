using System;

Polyclinic[] records = {
    new Polyclinic {
        CabinetName = "терапевт",
        CabinetNumber = 101,
        Doctor = "Иванов И.И.",
        Days = "1_понедельник - 2_вторник",
        StartTime = DateTime.Parse("08:00"),
        EndTime = DateTime.Parse("14:00")
    },
    new Polyclinic {
        CabinetName = "хирург",
        CabinetNumber = 205,
        Doctor = "Петров П.П.",
        Days = "3_среда - 4_четверг",
        StartTime = DateTime.Parse("09:30"),
        EndTime = DateTime.Parse("15:30")
    },
    new Polyclinic {
        CabinetName = "флюорография",
        CabinetNumber = 112,
        Doctor = "Сидорова А.А.",
        Days = "5_пятница - 6_суббота",
        StartTime = DateTime.Parse("10:00"),
        EndTime = DateTime.Parse("16:00")
    }
};

Console.WriteLine("список всех записей");
for (int i = 0; i < records.Length; i++)
{
    TimeSpan duration = records[i].EndTime - records[i].StartTime;
    Console.WriteLine($"кабинет: {records[i].CabinetName} (#{records[i].CabinetNumber}) | врач: {records[i].Doctor} | день: {records[i].Days} | время: {records[i].StartTime:HH:mm} - {records[i].EndTime:HH:mm} | длительность: {duration}");
}

Console.WriteLine("\nпроверка работы кабинета флюорографии");
Console.Write("введите день недели: (1-понедельник, 7-воскресенье) ");
string searchDay = Console.ReadLine();

Console.Write("введите время (чч:мм): ");
DateTime searchTime = DateTime.Parse(Console.ReadLine());

for (int i = 0; i < records.Length; i++)
{
    if (records[i].CabinetName == "флюорография")
    {
        char startDay = records[i].Days[0];
        char endDay = records[i].Days.Split(" - ")[1][0];

        if (searchDay[0] >= startDay && searchDay[0] <= endDay)
        {
            if (searchTime >= records[i].StartTime && searchTime <= records[i].EndTime)
            {
                Console.WriteLine("кабинет флюорографии может принять в это время.");
                return;
            }
        }
    }
}
Console.WriteLine("кабинет флюорографии не может принять в это время");

struct Polyclinic
{
    public string CabinetName;
    public int CabinetNumber;
    public string Doctor;
    public string Days;
    public DateTime StartTime;
    public DateTime EndTime;
}
