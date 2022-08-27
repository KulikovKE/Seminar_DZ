/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/


double[] array = new double [4];

double max = array[1];
double min = array[1];
double res = 0;
    for (int i = 0; i < 4; i++)
    {
    array[i] = new Random().Next(-1000,1000) + new Random().NextDouble();
    array[i] = Math.Round(array[i] ,2);
    Console.Write($"{array[i]}    ");

        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    if (min < 0)
    {
        res = max + min;
    }
    else
        res = max - min;

Console.WriteLine();
//Console.WriteLine($" максимальный {max}  минимальный {min}"); //вывод на экран для проверки
Console.WriteLine($"разницу между максимальным и минимальным элементом массива: {res}");

