/* Напишите программу, которая принимает на вход трехзначное число и на выходе
показывает вторую цифру этого числа
456 -> 5
782 -> 8
918 -> 1 */

//Комментарий: в данном коде цикл - это проверка введения именно трехзначного числа, в т.ч. отрицательного 

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());

int n = 1;
int i = 0;

        while (num / n > 0 || num*(-1) / n > 0)
        {
            n = n * 10;
            i = i + 1;
        }
if (i==3)
   {
     int result = num / 10 % 10;
    Console.WriteLine(result);
   }

else
    Console.WriteLine($"Вы ввели некорректное число {num}");
