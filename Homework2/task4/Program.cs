/*Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите номер дня недели ");
int a = Convert.ToInt32(Console.ReadLine());
if (a<8&a>0)
{
    if (a>5)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}