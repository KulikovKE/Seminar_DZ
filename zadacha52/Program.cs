/*Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}
Console.Write("укажите количество строк в массиве n=");
int n = int.Parse(Console.ReadLine());
Console.Write("укажите количество столбцов в массиве m=");
int m = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(n, m, 0, 10);
PrintArray(myArray);

double[] summColumn=new double[m];
 
for (int j = 0; j < myArray.GetLength(1); j++)
{
    for (int i = 0 ; i < myArray.GetLength(0); i++) 
    {
        summColumn[j]+=myArray[i, j]; 
    }             
    summColumn[j]=summColumn[j]/myArray.GetLength(0);
    Console.WriteLine($"среднее арифметическое элементов в столбце {j+1} = {summColumn[j]:f2}");
}


            

