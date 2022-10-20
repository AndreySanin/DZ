/*Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Не использовать строки для расчета.
645 -> 5
78 -> третьей цифры нет
326792 -> 6*/

Console.WriteLine("Введите число ");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int i = 2;
if (a>99)
{
    while (a/Convert.ToInt32((Math.Pow(10,i)))>0)
    {
        i=i+1;
    }
    Console.WriteLine($"{(a/Convert.ToInt32((Math.Pow(10,i-3))))%10}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}
