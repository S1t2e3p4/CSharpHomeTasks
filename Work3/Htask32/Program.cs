// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Например:
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите координаты X точки А: ");
double ax = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y точки А: ");
double ay = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Z точки А: ");
double az = int.Parse(Console.ReadLine());
Console.Write("Введите координаты X точки B: ");
double bx = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y точки B: ");
double by = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Z точки B: ");
double bz = int.Parse(Console.ReadLine());
double resulte = Math.Sqrt(Math.Pow(bx - ax,2)+Math.Pow(by - ay,2)+Math.Pow(bz - az,2));
Console.WriteLine($"Расстояние между двумя точками равно: {Math.Round(resulte,2)}");