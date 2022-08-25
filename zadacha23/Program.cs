/* Задача 23. Напишите программу, которая принимает на вход число (N) и выдает таблицу 
кубов чисел от 1 до N 

3 ->1, 8, 27
5 ->1, 8, 27, 64, 125 
*/


Console.Write("Введите любое положительное число N: ");
    
    int num = int.Parse(Console.ReadLine());
    for (int i = 1; num >= i; i++)
        {
        Console.WriteLine(Math.Pow(i, 3));
        }
    if (num <= 0)
        {
         Console.WriteLine("введенное число не является положительным");
        }
     

