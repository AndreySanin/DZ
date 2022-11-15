// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] Multiplication(int[,] MatrixA, int[,] MatrixB)
{
    int[,] MultMatrix = new int[MatrixA.GetLength(0), MatrixB.GetLength(1)];
    for (int i = 0; i < MultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < MultMatrix.GetLength(1); j++)
        {
            MultMatrix[i, j] = 0;
            for (int k = 0; k < MatrixA.GetLength(1); k++)
            {
                MultMatrix[i, j] = MultMatrix[i, j] + MatrixA[i, k] * MatrixB[k, j];
            }
        }
    }
    return MultMatrix;
}

int[,] CreateArray(int lenRows, int lenColumns) // Создание массива
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

System.Console.WriteLine("Введите число строк матрицы A: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число столбцов матрицы A (оно равно числу строк матрицы B): ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число столбцов матрицы B: ");
int k = Convert.ToInt32(Console.ReadLine());
int[,] Matrix_A = CreateArray(m, n);
int[,] Matrix_B = CreateArray(n, k);
int[,] MultMatrix = Multiplication(Matrix_A, Matrix_B);
System.Console.WriteLine("----------------------------------------");
PrintArray(Matrix_A);
System.Console.WriteLine("----------------------------------------");
PrintArray(Matrix_B);
System.Console.WriteLine("----------------------------------------");
PrintArray(MultMatrix);