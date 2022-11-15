// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int F(int[,] ar)
{
    int min_sum=0;
    for (int i = 0; i < ar.GetLength(1); i++)
    {
        min_sum=min_sum+ar[0,i];
    }
    int min_str=0;
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        int sum=0;
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            sum=sum+ar[i,j];
        }
        if(sum<min_sum)
        {
            min_str=i;
        }
    }
    return min_str;
}

int [,] CreateArray(int lenRows, int lenColumns) // Создание массива
{
    int [,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-5,6);
        }
    }
    return array;
}

void PrintArray(int[,] array) // Печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t"); 
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите число строк (m): ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = CreateArray(m,n);
PrintArray(arr);
System.Console.WriteLine($"Индекс строки с наименьшей суммой: {F(arr)}");