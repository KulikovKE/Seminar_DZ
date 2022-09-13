/*Задача со звездочкой: Напишите программу, которая реализует обход 
введенного двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.

1 2 3
4 5 6 -> 7 8 9 6 3 2 1 4 5
7 8 9  
*/

int[,] array = new int [,]

// массив 3х3
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9},
};

//массив 4х4
/*
{
    {1,   2,  3,  4,},
    {6,   7,  8,  9},
    {10,  11, 12, 13},
    {14,  15, 16, 17}
 
}; 
*/

//массив 5х5

/*
{
    {1,   2,   3,  4,  5},
    {6,   7,   8,  9,  10},
    {11,  12,  13, 14, 15},
    {16,  17,  18, 19, 20},
    {21,  22,  23, 24, 25} 
}; 
*/

// массив 4х5
/*
{
    {1,   2,   3,   4,   5},
    {6,   7,   8,   9,   10},
    {11,  12,  13,  14,  15},
    {16,  17,  18,  19,  20}
    
}; 
*/
//массив 5*4

/*
{
    {1,   2,  3,  4,},
    {6,   7,  8,  9},
    {10,  11, 12, 13},
    {14,  15, 16, 17},
    {18,  19, 20, 21}
}; 
*/

for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            {
             Console.Write($"{array[i, j]}    "); 
            }    
        Console.WriteLine();
    }
    
Console.WriteLine();
int[,] arr = new int [array.GetLength(0),array.GetLength(1)];

{
int i=0;
int j=0;
int count=0;
int n=array.GetLength(0);

while (count<n/2)
    {    
        for (j = count; j < array.GetLength(1)-1-count; j++) // вправо (A)
            {
                arr[i,j] = array[array.GetLength(0)-1-count, j];
                Console.Write($"{arr[i, j]} ");
                // Console.WriteLine($"  A  i={i}, j={j},   count={count}");// для решения задачи и понимания                    
            }

        for (i =array.GetLength(0)-1-count; i > count; i--) // Вверх (B)
            {       
                arr[i,j] = array[i,array.GetLength(1)-1-count];
                Console.Write($"{arr[i, j]} ");
                //  Console.WriteLine($"  B  i={i}, j={j},   count={count}");// использовал для решения задачи и понимания
            }
  
        for (j = array.GetLength(1)-1-count; j >count; j--) // влево (C)
            {      
                arr[i,j] = array[i,j];
                Console.Write($"{arr[i, j]} ");
                //Console.WriteLine($"  C   i={i}, j={j},   count={count}");//использовал для решения задачи и понимания
            }

        for (i = count; i < array.GetLength(0)-1-count; i++) // вниз (А)
            {      
                arr[i,j] = array[i, j];
                Console.Write($"{arr[i, j]} ");
                //  Console.WriteLine($"  D   i={i}, j={j},   count={count}");//использовал для решения задачи и понимания
            }
count++;
     }
    
for (i = count; i == array.GetLength(0)-1-count; i++) // идем вправо, в центр массива
    for (j = count; j == array.GetLength(1)-1-count; j++) 
        {
            arr[i,j] = array[i, j];
            Console.Write($"{arr[i, j]} ");
            // Console.WriteLine($" end  i={i}, j={j},   count={count}"); // использовал для решения задачи и понимания                         
        }
}
Console.WriteLine();
Console.WriteLine();
