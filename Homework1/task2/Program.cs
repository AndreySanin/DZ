// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("Введите первое число");
int a = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine ("Введите второе число");
int b = int.Parse (Console.ReadLine() ?? "0");
Console.WriteLine ("Введите третье число");
int c = int.Parse (Console.ReadLine() ?? "0");
int max = a;
if (max<b)
{
    max = b;
    if (max<c)
    {
        max = c;
        Console.WriteLine ($"Максимум равен {max}");
    }
    else
    {
        Console.WriteLine ($"Максимум равен {max}");
    }
}
else
{
    if (max<c)
    {
        max = c;
        Console.WriteLine ($"Максимум равен {max}");
    }
    else
    {
        Console.WriteLine ($"Максимум равен {max}");
    }
}
