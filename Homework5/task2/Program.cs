/*Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

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
        array[k]=Rnd(1,10);
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

int Sum(int[] ar) //Подсчет суммы
{
    int count = 0;
    for (int i=0; i<ar.Length; i++)
    {
        if (i%2==1)
        {
            count=count+ar[i];
        }
    }
    return count;
}

Console.WriteLine("Введите длину массива: ");
int len=Convert.ToInt32(Console.ReadLine());
int[] arr=CreateArray(len);
PrintArray(arr);
Console.WriteLine($"-> {Sum(arr)}");