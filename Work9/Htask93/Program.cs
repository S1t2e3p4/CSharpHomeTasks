// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Run();
    void Run()
{
    Console.WriteLine("Введите неотрицательное число < m >: ");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите неотрицательное число < n >: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine($"А({m}, {n}) = {Akkerman((uint)m, (uint)n)}");
}

uint Akkerman(uint m, uint n)
{
    if (m == 0)  return n+1; 
    if (m > 0 && n ==0)  return Akkerman(m - 1, 1); 
    return Akkerman(m-1,Akkerman(m,n-1));
}