/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 
*/

Console.WriteLine("задайте числовой промежуток от M до N");
Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

int sum(int m, int n)
{
    return (m+n)*(n-m+1)/2;
}
if (m == n || m > n)
    {   
       Console.WriteLine("значение M должно быть меньше N");
    }
else
Console.WriteLine($"cумма натуральных элементов в заданном промежутке {sum(m,n)}");
