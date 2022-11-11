// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] AverageOfEachColumn(int[,] arr)
{
    double[] sums = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum=sum+arr[j,i];
        }
        sums[i] = Math.Round(sum/arr.GetLength(0),1);
    }
    return sums;
}

void PrintArray(double[] array) 
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[,] arr = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
PrintArray(AverageOfEachColumn(arr));