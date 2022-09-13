/*Задача 43. Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/



Console.WriteLine("введите значения b1,k1 и b2,k2");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());

bool Check(double num1, double num2, double num3, double num4)
    {
    return num1==num3 && num2==num4 || num2==num4;
    }
    if(Check(b1, k1, b2, k2))
    {
        Console.WriteLine("прямые параллельны или совпадают");
        return;
    }
else  
    {
        double x=(b2-b1)/(k1-k2);
        double y = k1 * x + b1;
        Console.WriteLine($"точка пересечения двух прямых ({x}, {y})");
    }

