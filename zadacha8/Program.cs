/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные
числа от 1 до N */


Console.WriteLine("Введите число от 1 до N");
int num = int.Parse(Console.ReadLine());

while (num>1)
{
    if (num%2==0)
        {
            Console.WriteLine(num);
        }
         num--;
}

