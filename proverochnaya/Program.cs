/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
 */  
    


Console.WriteLine("Введите текст, состоящий из любого количества любых символов"); //вводим текс
string text = Console.ReadLine(); // считываем введенную информацию с консоли
string [] words = text.Split(' '); //объявляем новый массив и разделяем введенный текст по границам введенных слов/символов
string [] resultArray = new string[words.Length]; //объявляем новый массив для записи результатов       

void ConditionArray(string[] words, string[] resultArray) // в методе прописываем условие  
{
    int i = 0;
    foreach (var result in words)  // с помощью оператора foreach выполняем итерацию по элементам введенного массива
    {
        if (result.Length <= 3)
        {
            resultArray[i] = result;     
            i++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ConditionArray(words, resultArray);
PrintArray(resultArray);     
      


