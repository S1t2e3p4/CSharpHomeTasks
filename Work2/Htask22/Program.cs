// Напишите программу, которая выводит третью цифру заданного числа, или сообщает, что третьей цифры нет.
// Например:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
 Console.WriteLine("Введите число: ");
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
 