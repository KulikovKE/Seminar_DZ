/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = new int[4];
int sum=0;

    for (int i=0; i<4; i++)
    {
        array[i] = new Random().Next(-100,100);
        Console.Write($"{array[i]} ");
       
       if (array[i]%2 == 1 || array[i]%2 == -1)
        {
            sum+=array[i];                               
        }   
    }
Console.WriteLine();
Console.WriteLine($"сумма нечетных элементов массива: {sum}");