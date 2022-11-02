// Напишите программу, котрая принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Например:
// 4 -> Да
// -3 -> Нет
// 7 -> 2Нет
 Console.Clear();
        Console.WriteLine("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        if (number>0)
        {
        int count = number/2;
        if ((count*2) < number)
            {
            Console.WriteLine ($"Число {number} - Нечётное");
            }
        else
        {
         Console.WriteLine ($"Число {number} - Чётное");
        }
        }
        else
        {
          int count = number/2;
        if ((count*2) > number)
            {
            Console.WriteLine ($"Число {number} - Нечётное");
            }
        else
        {
         Console.WriteLine ($"Число {number} - Чётное");
        }  
        }
    
        