// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой 
// строки двумерного массива.

double [,] Ordering(double[,] arr) // Функция упорядочивания 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        double temp;        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int max_k=j;
            for(int k=j; k<arr.GetLength(1); k++)
            {
                if(arr[i,k]>arr[i,max_k])
                {
                    max_k=k;
                }                                
            }
            temp=arr[i,j];
            arr[i,j]=arr[i,max_k];
            arr[i,max_k]=temp;
        }

    }
    return arr;
}

double [,] CreateArray(int lenRows, int lenColumns) // Создание массива
{
    double [,] array = new double[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(random.NextDouble()*10,1);
        }
    }
    return array;
}

void PrintArray(double[,] array) // Печать массива
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
double[,] arr = CreateArray(m,n);
PrintArray(arr);
System.Console.WriteLine("");
PrintArray(Ordering(arr));

/*
double [,] Ordering(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        double temp=0;
        
        for (int j = 0; j < arr.GetLength(1)-1; j++)
        {
            if(arr[i,j]<arr[i,j+1])
            {
                temp = arr[i,j+1];
                arr[i,j+1]=arr[i,j];
                arr[i,j]=temp;
                j=-1;
            }
        }
    }
    return arr;
}
*/