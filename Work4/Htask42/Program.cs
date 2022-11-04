// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Например:
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("Введите число: ");  
int count = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумму цифр числа {count} равна {SumNums(count)}");

int SumNums(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number%10;
        number /= 10;
    }
    return sum;
}