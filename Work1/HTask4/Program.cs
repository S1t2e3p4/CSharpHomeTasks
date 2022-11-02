// Напишите программу, котрая принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Например:
// 5 -> 2,4
// 8 -> 2,4,6,8
 Console.Clear();
 Console.WriteLine("Введите число: ");
 int number = int.Parse(Console.ReadLine());
 if (number>1)
 {
    int N=2;
    while (N<=number)
    {
    Console.Write (N);
    Console.Write (", ");
    N=N+2;
    }
 }
    else
    {
        int N = -2;
        while (N>=number)
        {
        Console.Write (N);
        Console.Write (", ");
        N=N-2;
        }
    }
