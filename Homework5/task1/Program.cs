/*Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int Rnd(int a, int b) //Генерация случ числа
{
    Random x = new Random();
    int n = x.Next(a,b);
    return n;
}

int[] CreateArray(int len) //Создание массива
{
    int[] array=new int[len];
    for(int k=0; k<len; k++)
    {
        array[k]=Rnd(100,1000);
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

int CountEven(int[] ar) //Подсчет четных
{
    int count = 0;
    for (int i=0; i<ar.Length; i++)
    {
        if (ar[i]%2==0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите длину массива: ");
int len=Convert.ToInt32(Console.ReadLine());
int[] arr=CreateArray(len);
PrintArray(arr);
Console.WriteLine($"-> {CountEven(arr)}");
