/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/


int[,] GetArray(int n, int m, int minValue, int maxValue)
{
    int[,] newArray = new int[n, m];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {    
            newArray[i, j] = new Random().Next(minValue, maxValue+1); ;
        }
    }
    return newArray;
}

void PrintArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}   ");
        Console.WriteLine();
    }
}
Console.Write("укажите количество строк в массиве n=");
int n = int.Parse(Console.ReadLine());
Console.Write("укажите количество столбцов в массиве m=");
int m = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(n, m, 0, 100);
PrintArray(myArray);


Console.WriteLine("Введите позицию элемента в заданном массиве a и b");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a>m && b>n)
{
    Console.WriteLine("элемента с заданной позицией в массиве нет");
}
else
{
    int i=a;
    int j=b;
    int znachenieMyArray = myArray[i,j];
    Console.WriteLine($"элемент с заданной позицией в массиве {znachenieMyArray}");
}

