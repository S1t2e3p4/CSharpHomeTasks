// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Например: 
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите номер дня недели (цифру от 1 до 7): ");
int count = int.Parse(Console.ReadLine());
if (count<1 || count>7)
{
    Console.WriteLine ("Некорректно указано значение");
}
if (numDay == 6 || numDay == 7)
{
    Console.WriteLine ("Выходной - Отдыхаем!!!");
}
else
    {
        Console.WriteLine ("Рабочий день - арбайтен!");
    }