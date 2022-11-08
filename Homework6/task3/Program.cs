/*Задача 3: * Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
1 2 3
3 4 5
3+5=8, 1+2+3=6, 8-6=2*/

int[,] CreateArray(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-5, 6); 
        }
    }
    return array;
}

void PrintArray(int[,] array)
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

int SumMax(int[,] array) //Сумма максимумов по строкам
{
    int sum=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int max=array[i,0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (max<array[i,j])
            {
                max=array[i,j];
            } 
        }
        sum=sum+max;
    }
    return sum;
}

int SumMin(int[,] array) //Сумма минимумов по столбцам
{
    int sum=0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int min=array[0,j];
        for (int i = 1; i < array.GetLength(0); i++)
        {
            if (min>array[i,j])
            {
                min=array[i,j];
            } 
        }
        sum=sum+min;
    }
    return sum;
}

int[,] array = CreateArray(3, 4);
PrintArray(array);
Console.WriteLine($"Сумма максимумов по строкам = {SumMax(array)}");
Console.WriteLine($"Сумма минимумов по столбцам = {SumMin(array)}");
Console.WriteLine($"Разность сумм = {SumMax(array)-SumMin(array)}");