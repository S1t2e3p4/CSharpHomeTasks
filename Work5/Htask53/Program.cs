// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Например:
// [3 7 22 2 78] -> 76
Console.Clear();
double [] GetArray(int size)
{
double [] res = new double[size];
    for (int i = 0; i < size; i++)
    {
    res[i] = new Random().NextDouble();
    Console.Write($"{res[i]} ");
    }
    return res;
}

double MinValue (double[] array)
{
    double min = array[0];
    foreach (double el in array)
{
    if (min > el)
    min = el;
}
return min;
}

double MaxValue (double[] array)
{
    double max = array[0];
    foreach (double el in array)
{
    if (max < el)
    max = el;
}
return max;
}

double [] array = GetArray(4);
double max = MaxValue(array);
double min = MinValue(array);
Console.WriteLine(" ");
Console.Write($"Разница между max и min элементом массива равна {max-min}");