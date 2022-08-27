/*Урок 5.
Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька.
 Реализовать невозрастающую сортировку.
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
[1,2,2,3,2] -> [3, 2, 2, 2, 1]
*/

Console.WriteLine("введите массив из 5 цифр");
int [] array = new int [5];
    for (int i = 0; i < 5; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < 5; i++)
    {
        for (int j = i+1; j <5; j++)
        {
            if (array[i] < array[j])
            { 
                int n=array[i];
                array[i] = array[j];
                array[j] = n;
            }
   
        }

         Console.Write($"{array[i]}    ");
    }
Console.WriteLine();