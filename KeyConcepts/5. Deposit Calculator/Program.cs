double depositAmount = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double annualRate = double.Parse(Console.ReadLine())/100;

double finalSum = depositAmount + months*(annualRate*depositAmount)/12;

Console.WriteLine($"{finalSum:F2}");

