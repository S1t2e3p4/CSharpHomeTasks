// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Например:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите число1: ");
int numberOne=int.Parse(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int numberTwo=int.Parse(Console.ReadLine());
Console.Write($"{numberOne} в {numberTwo}-й степени = {LevelNumber(numberOne,numberTwo)}");
 
int LevelNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
   return result;
}
