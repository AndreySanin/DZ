/*Задача 3: Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 7, 8*/

int Rnd(int a, int b) //Генерация случ числа
{
    Random x = new Random();
    int n = x.Next(a,b);
    return n;
}

int[] array=new int[8];
for(int k=0; k<7; k++)
{
    array[k]=Rnd(0,10);
}

int i = 0;
while (i<array.Length)
{
    Console.Write($"{array[i]} ");
    i++;
}