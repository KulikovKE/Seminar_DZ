/*Напишите программу, которая принимает на вход цифру, обозначающую день недели 
и проверяет является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число от 1 или 7");
int num = int.Parse(Console.ReadLine());

    if  (num<1 || num>7)
         {
            Console.WriteLine("Вы ввели некорректное число");
         }
    else switch (num)
    {
    case 1: Console.WriteLine ("Введенному числу соответствует Понедельник");
    break;
    case 2: Console.WriteLine ("Введенному числу соответствует вторник");
    break;
    case 3: Console.WriteLine ("Введенному числу соответствует Среда");
    break;
    case 4: Console.WriteLine ("Введенному числу соответствует Четверг");
    break;
    case 5: Console.WriteLine ("Введенному числу соответствует Пятница");
    break;
    case 6: Console.WriteLine ("Введенному числу соответствует Суббота");
    break;
    case 7: Console.WriteLine ("Введенному числу соответствует Воскресенье");
    break;
    }
    if (num==6 || num ==7)  
         {
            Console.WriteLine("Указанный день является выходным");
         }