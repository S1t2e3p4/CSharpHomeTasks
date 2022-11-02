// Напишите программу, котрая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Например:
//2,3,7 -> 7
//44,5,78 -> 78
//22,3,9 -> 22
 Console.Clear();
        Console.WriteLine("Введите первое число: ");
        int numberOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите третье число: ");
        int numberThre = int.Parse(Console.ReadLine());
        int max = numberOne;
        int max2 = numberTwo;
        if (numberTwo > numberThre)
            {
            max2=numberTwo;
            }
        else
        {
            max2=numberThre;
        }
        if(max>max2)
        {
            Console.WriteLine ($"Большее число max={max}");
        }
        else
        {
            max=max2;
            Console.WriteLine ($"Большее число max = {max}");
        }
        
