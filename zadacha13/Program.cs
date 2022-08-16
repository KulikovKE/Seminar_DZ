/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. (Строки и циклы в решении использовать нельзя!)
645 -> 6 (в семинаре указана цифра 5 как третье число, на сайте - 6)
78 -> третьей цифры нет
32679 -> 6 */


Console.WriteLine("Вариант когда третью цифру искать слева направо");
Console.WriteLine("Введите целое положительное число");
int num = int.Parse(Console.ReadLine());
int n = 3; // n = 3 если требуется вывести третью цифру 

    if (num < 0)
        {
          Console.WriteLine("Вы ввели отрицательное число");
          return;
        }

int kchisel = (int)Math.Log10(num) + 1; // количество цифр в числе

    if (num > 0 && kchisel >= 3)
        {
          int stepen = (int)Math.Pow(10, kchisel - n);
          int result = num / stepen % 10;
          Console.WriteLine($"третьей цифрой заданного числа {num} является {result}");
        }
    else
        {
          Console.WriteLine($"Третьей цифры в числе {num} нет");
        }


/*
Console.WriteLine("Вариант когда третью цифру искать справа налево");
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

  if (num<99)
    {
      Console.WriteLine($"Третьей цифры в числе {num} нет");
    }
  else
    {
      int result = num / 100 % 10;
      Console.WriteLine($"Третья цифрa в числе {num} является {result}");
    }
*/

/*
Console.WriteLine("Вариант с циклом(( с учетом ввода отрицательного числа");
Console.WriteLine("Введите число");
long num = long.Parse(Console.ReadLine());
long i = 0;
long n = 1;
long result = 0;
    while (num / n > 0 || num*(-1) / n > 0)
        {
          n = n * 10;
          i = i + 1;
        }
long a1 = num * 1000;
long a2 = a1 / n;
result = a2 % 10;

    if (i<3)
        {
          Console.WriteLine($"Третьей цифры в числе {num} нет");
        }  
   else
        {
          Console.WriteLine($"третьей цифрой заданного числа {num} является {result}");  
        }
 

*/


    











