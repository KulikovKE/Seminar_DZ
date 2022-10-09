     /*
       int[,] mas = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < (mas.GetUpperBound(0) + 1); i++)
            {
                for(int j=0;j< (mas.Length) / (mas.GetUpperBound(0) + 1); j++)
                {
                    Console.Write($"{mas[i, j]} ");
                }
               Console.WriteLine("");
            }
            Console.WriteLine();
            for (int i = (mas.GetUpperBound(0) + 1); i > 0; i--)
            {
                for (int j = 0; j < (mas.Length) / (mas.GetUpperBound(0) + 1); j++)
                {
 
                    Console.Write($"{mas[j, i-1]} ");
                }
                Console.WriteLine();
            }
        
    */

/*
 int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(  "    " + arr[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine();
             
            }
            Console.WriteLine();
            Console.WriteLine();
 
            // начинаю творить
            
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("    " + arr[3 - j - 1, i]);    // повернул по часовой на 90 градусов
                    //Console.Write("    " + arr[3 - i - 1, j]);    //  поменялись местами первая и третья строки
                    //Console.Write("    " + arr[3 - j - 1, 3 - i - 1]);    //   поменялись относительно второстепенной диагонали
                    //Console.Write("    " + arr[3 - i - 1, j]);     //   задание выполнено
                }
                Console.WriteLine();
                Console.WriteLine();
            }
 
 
            Console.ReadKey();


            */

/*
//Console.WriteLine("введите размер массива a и b");
//int N = int.Parse(Console.ReadLine());
    int[,] arr = new int[3,3];  //{ { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    int N=3;
    int iBeg   = N;
    int iEnd   = 0;
    int jBeg   = 0;
    int jEnd   = N;
    int amount = N * N;
    int value  = 0;
   
    while( value < amount )
    {
       for( int i = --iBeg; i >= iEnd; i-- )  arr[i, jBeg]     = ++value;
        for( int i = ++jBeg; i <  jEnd; i++ )   arr[iEnd, i]     = ++value;
        for( int i = ++iEnd; i <  iBeg; i++ )   arr[i, jEnd - 1] = ++value;
        for( int i = --jEnd; i >= jBeg; i-- )   arr[iBeg, i]     = ++value;
    }
    for( int i = 0; i < N; i++ )
    {
        for( int j = 0; j < N; j++ )
           // cout << setw( 3 ) << matr[i, j];
      Console.Write( "{0,3}", arr[i, j]); 
      
        Console.WriteLine(); 
    }
    return 0;
*/


/*
Console.WriteLine("Введите количество элементов в строке"); 
int n = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите количество элементов в cтолбце"); 
int m = int.Parse(Console.ReadLine()); 

//int[,] mas = new int{ { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

int[,] mas = new int[m, n]; 
int k = 1; 
int t = 0; 
int i, j = 0; 
int n1 = n; 
int m1 = m; 
 
while (k <= n1 * m1) 
{ 
for (i = t; i < n; i++) 
    mas[j, i] = k++; 
    j = n - 1; 
for (i = t + 1; i < m; i++) 
    mas[i, j] = k++; 
    j = m - 1; 
for (i = n - 2; i >= t; i--) 
    mas[j, i] = k++; 
    j = t; 
for (i = m - 2; i > t; i--) 
    mas[i, j] = k++; 

n--; 
m--; 
t++; 
j = t; 
} 


for (i = 0; i < mas.GetLength(0); i++) 
{ 
for (j = 0; j < mas.GetLength(1); j++) 
Console.Write("{0,2} ", mas[i, j]); 
Console.WriteLine(); 
} 
 */

/*

int[,] array = new int [,]

{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
    
};

for (int i=0; i<array.GetLength(0); i++)
{
    for (int j=0; j<array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} "); 
    
    }    
Console.WriteLine();
}
Console.WriteLine();
int[,] arr = new int [array.GetLength(0),array.GetLength(1)];

{
int i=0;
int j=0;
//int n=3;
//, m =3;
int t=0; //-


//int count = 8; //- удалить

//while (t<3) //-
    //{


   //for (j = t; j <array.GetLength(1)-1-t; j++) // идем вправо
    //    {      
    //        arr[i,j] = array[array.GetLength(0)-1, j];
     //       Console.Write($"{arr[i, j]}   ");
      //  }

      j=t;
      
 if (j <array.GetLength(1)-1-t)
    {
    arr[i,j] = array[array.GetLength(0)-1, j+t];
     Console.Write($"{arr[i, j]}   ");
    }
else arr[i,j]= array[array.GetLength(0)-1-t, j];

   for (i =array.GetLength(0)-1; i > 0; i--) // идем вверх работает
        {      
            arr[i,j] = array[i,array.GetLength(1)-1];
            Console.Write($"{arr[i, j]}   ");
        }
  
    
   for (j = array.GetLength(1)-1; j >0; j--) // идем влево работает
        {      
            arr[i,j] = array[i,j];
            Console.Write($"{arr[i, j]}   ");
        }
    for (i = 0; i < array.GetLength(0)-1; i++) // идем вниз  работает
        {      
            arr[i,j] = array[i, j];
            Console.Write($"{arr[i, j]}   ");
        }

        
//удалить до count
 //for (j = n-1-1; j < array.GetLength(1)-1-1; j++) // идем вправо
 //       {      
 //           arr[i,j] = array[array.GetLength(0)-1-1, j];
  //          Console.Write($"{arr[i, j]}   ");
   // }
    //count++;  //-
    Console.WriteLine($"t={t}, i={i}, j={j}");
t++;
j++;
    }
//}
 Console.WriteLine();
Console.WriteLine();


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
        for (j = count; j < array.GetLength(1)-1-count; j++) // вправо A
            {
                arr[i,j] = array[array.GetLength(0)-1-count, j];
                Console.Write($"{arr[i, j]} ");
                // Console.WriteLine($"  A  i={i}, j={j},   count={count}");// для решения задачи и понимания                    
            }

        for (i =array.GetLength(0)-1-count; i > count; i--) // Вверх B
            {       
                arr[i,j] = array[i,array.GetLength(1)-1-count];
                Console.Write($"{arr[i, j]} ");
                //  Console.WriteLine($"  B  i={i}, j={j},   count={count}");// использовал для решения задачи и понимания
            }
  
        for (j = array.GetLength(1)-1-count; j >count; j--) // влево C
            {      
                arr[i,j] = array[i,j];
                Console.Write($"{arr[i, j]} ");
                //Console.WriteLine($"  C   i={i}, j={j},   count={count}");//использовал для решения задачи и понимания
            }

        for (i = count; i < array.GetLength(0)-1-count; i++) // вниз А
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

//Проверочная по первоу курсу
/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
 */  
    
/*

Console.WriteLine("Введите текст, состоящий из любого количества любых символов"); //вводим текс
string text = Console.ReadLine(); //читаем его

int i=0;

string [] words = text.Split(' '); //объявляем новый массив и разделяем введенный текст по границам введенных слов/символов
string [] resultArray = new string[text.Length]; //объявляем новый массив для записи результатов 

    foreach (var result in words)  // с помощью оператора foreach выполняем итерацию по элементам введенного массива
    {
        if (result.Length <= 3)
        {
            resultArray[i] = result;     
            Console.Write($"{resultArray[i]} ");
            i++;
        }
           
    }
Console.WriteLine();   


*/