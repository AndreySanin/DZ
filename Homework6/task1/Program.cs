/* Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество 
положительных)
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[] CreateArray(int len) //Создание массива
{
    Console.WriteLine("Введите числа: ");
    int[] array=new int[len];
    for(int k=0; k<len; k++)
    {
        array[k]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array) //Печать массива
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CountPositive(int[] ar) //Подсчет количества положительных
{
    int count = 0;
    for (int i=0; i<ar.Length; i++)
    {
        if (ar[i]>0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Укажите количество вводимых чисел (M): ");
int len=Convert.ToInt32(Console.ReadLine());
int[] arr=CreateArray(len);
PrintArray(arr);
Console.WriteLine($"-> {CountPositive(arr)}");