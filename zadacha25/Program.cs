/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Реализовать функцию возведения в степень самостоятельно!
*/


Console.WriteLine("Введите два числа А и B: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int result =1;

for (int i = 1; B >= i; i++)
        {
           result =result*A;
        }

Console.WriteLine(result); 
  
/*    
Console.WriteLine("Введите два числа А и B: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

for (int i = 1; B >= i; i++)
        {
           Console.WriteLine(Math.Pow(A, B));   
           break;
        }
  */

