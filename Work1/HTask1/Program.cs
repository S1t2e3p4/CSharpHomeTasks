internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее.
        // Например:
        // а=5; b=7 -> max=7
        // а=2; b=10 -> max=10
        // а=-9; b=-3 -> max=-3
        Console.Clear();
        Console.WriteLine("Введите первое число: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int numberTwo = int.Parse(Console.ReadLine());
        if (numberOne > numberTwo)
        {
            Console.WriteLine($"Большее число max = {numberOne} ");
        }
        else
        {
            Console.WriteLine($"Большее число max = {numberTwo} ");
        }
    }
}