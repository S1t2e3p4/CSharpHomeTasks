// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");

int[,] array = GetArray(rows, columns, 0,10);

ArithmeticMeanOfColumns(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        result[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
return result;
}
void ArithmeticMeanOfColumns(int [,]GetArray)
{
for (int j = 0; j < GetArray.GetLength(1); j++)
    {
    double sum = 0;
    for (int i = 0; i < GetArray.GetLength(0); i++)
        {
        sum += GetArray[i, j];
        }
    Console.WriteLine($"В столбце {j} ={ sum / GetArray.GetLength(0)} /");
    }

}