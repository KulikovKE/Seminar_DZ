/* Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите три числа с новой строки");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

 if (num1>num2 && num1>num3)
    {
        Console.WriteLine($"Максимальное введенное число {num1}");
    }
    else if (num2>num1 && num2>num3)
    {
            Console.WriteLine($"Максимальное введенное число {num2}");
    }
    else 
    {
        Console.WriteLine($"Максимальное введенное число {num3}");
    }