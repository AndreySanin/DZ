// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

void GetElement(int row, int column, int[,] arr)
{
    if(row<arr.GetLength(0)&column<arr.GetLength(1))
    {
        Console.WriteLine(arr[row, column]);
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}

int[,] arr = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());
GetElement(row,column,arr);