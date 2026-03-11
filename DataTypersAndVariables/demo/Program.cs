using System.Globalization;

Console.WriteLine(double.TryParse("1.23", out var a)); // true ако е точка
Console.WriteLine(double.TryParse("1,23", out var b)); // true ако е запетая
Console.WriteLine($"Separator: {CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator}");