/*Задача 29: (необязательная) Напишите программу, которая создает массив из введенных через запятую цифр и выводит этот массив на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
    {
        Console.Write($"{col[position]}");
        if (position < count - 1) Console.Write(", ");
        position++;
    }
    Console.Write("]");
}
Console.WriteLine("Введите эементы масива через запятую без пробелов.");
int[] myArray = Array.ConvertAll<string, int>(Console.ReadLine().Split(','), elem => { return System.Convert.ToInt32(elem); });


Console.WriteLine("Выводим массив");
PrintArray(myArray);
