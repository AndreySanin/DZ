// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Введите первое число");
int a = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine ("Введите второе число");
int b = int.Parse (Console.ReadLine() ?? "0");
if (a>b)
{
    Console.WriteLine($"{a} - большее, {b} - меньшее");
}
else if (a<b)
{
    Console.WriteLine($"{b} - большее, {a} - меньшее");
}
else
{
    Console.WriteLine("введенные числа равны");
}
