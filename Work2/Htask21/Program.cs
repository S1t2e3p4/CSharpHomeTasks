// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Например:
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
 Console.WriteLine("Введите трёхзначное число: ");
 int number = int.Parse(Console.ReadLine());
 if ((number>99&&number<1000)||(number<-99&&number>-1000))
 {
 int Ostatok = number%100;
 int betveenCount = Ostatok/10;
 if (betveenCount<0)
 {
    betveenCount=betveenCount*-1;
 }
 Console.WriteLine (betveenCount);
 }
 else
 {
    Console.WriteLine ("Ошибка! Введено некорректное значение.");
 }
 