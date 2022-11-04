// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Например:
// [345, 897, 568, 234] -> 2

Console.Write("Введите число ");
int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
    res[i] = new Random().Next(minValue, +  1);
    Console.Write($"{res[i]} ");
    }
    return ;
}
int[] array = GetArray(4, 100, 1000);
Console.WriteLine();
foreach (int el in array)
{
    if (el % 2 != 0)
        continue;
    ++++
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел равно {sumEvenNumbers}");
