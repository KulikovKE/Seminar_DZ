/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("укажите количество элементов в массиве");
int size = int.Parse(Console.ReadLine());

void Kolichestvo(int size)
{
int[] Myarray = new int[size];
    for (int i=0; i<size; i++)
    {
        Console.WriteLine($"введите {i+1} элемент массива (положительный или отрицательный)");
        Myarray[i] = int.Parse(Console.ReadLine());
    }
Console.WriteLine(String.Join(" ", Myarray));

int kolPositive = 0;
    foreach (int positive in Myarray)
    {
        if (positive > 0) 
        kolPositive++;
    } 

Console.WriteLine($"Количество положительных элементов массива равно {kolPositive}");
}
Kolichestvo(size);
