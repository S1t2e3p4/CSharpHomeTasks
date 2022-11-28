// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Например:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Run();

void Run() 
{
    Console.WriteLine("Введите число < M >: ");
    int numberM = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число < N >: ");
    int numberN = int.Parse(Console.ReadLine());

    Console.WriteLine($"Cумма натуральных элементов в промежутке от M до N равна: {Sum(numberN, numberM)}");

}

int Sum(int numberM, int numberN)
{
    if (numberM == numberN) return numberN;

    return numberM + Sum(--numberM, numberN);
}