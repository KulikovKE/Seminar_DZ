/*напишите программу, которая будет выдавать название дня недели по заданному номеру
 3-> Среда
 5-> Пятница  */

Console.WriteLine("введите число от 1 или 7");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Введенному числу соответствует Понедельник");}
if (num==2)
{
    Console.WriteLine("Введенному числу соответствует вторник");}
if (num==3)
{
    Console.WriteLine("Введенному числу соответствует Среда");}
if  (num==4)
{
    Console.WriteLine("Введенному числу соответствует Четверг");}
if  (num==5)
{
    Console.WriteLine("Введенному числу соответствует Пятница");}
if  (num==6)
{ 
     Console.WriteLine("Введенному числу соответствует Суббота");}
if  (num==7)
{
    Console.WriteLine("Введенному числу соответствует Воскресенье");}

if  (num<1 || num>7)
{
    Console.WriteLine("Вы ввели некорректное число");}