/*Задача 29: Напишите программу, которая задаёт массив из N элементов,
 заполненных случайными числами из [a, b] и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("укажите любой дипазон от a до b ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine("укажите размер массива N ");
int N = int.Parse(Console.ReadLine());
void RandArray()

{
    int[] array = new int[N];
    for(int i=0; i<N; i++)
    {
        array[i]= new Random().Next(a,b);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

RandArray( );

