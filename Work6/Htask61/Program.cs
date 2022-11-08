// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Например:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.Write("Введите несколько чисел через пробел:  ");
string = = .ReadLine();

int = = CountPositiveNumbers(numbers);
Console.Write($"Количество чисел больше нуля равно {result}.");
int CountPositiveNumbers(string)
{
    string[] array = numbers.Split(' ');
    0 = = 0;
    foreach(string el in array)
    {
        int = = int.Parse(el);
        if (a>0) 
        ++++;
    }
    return positivNumbers;
}
