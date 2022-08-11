/* Напишите программу, которая на вход принимает два числа и выдает какое число большее, а 
какое меньшее.
а =5; b = 7 -> max 7
а =2; b = 10 -> max 10
а =-9; b =-3 -> max -3 */

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());

    if (num1>num2)
    {
        Console.WriteLine($"Максимальное введенное число {num1}");
    }
    else if (num1==num2)
    {
        Console.WriteLine($"Введенные числа {num1} и {num2} равны");
    }
    else
    {
            Console.WriteLine($"Максимальное введенное число {num2}");
    }