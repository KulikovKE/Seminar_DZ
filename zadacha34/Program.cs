/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


int[] array = new int[4];
int n=0;
    for (int i=0; i<4; i++)
    {
        array[i] = new Random().Next(100,999);
        Console.Write($"{array[i]} ");
        
        if (array[i]%2 == 0)
        {
          n++;
        }    
    }
Console.WriteLine();
Console.WriteLine(n);
