int pagesInTheBook = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int daysToFinish = int.Parse(Console.ReadLine());
int hoursToReadPerDay = (pagesInTheBook / pagesPerHour) / daysToFinish;
Console.WriteLine(hoursToReadPerDay);
