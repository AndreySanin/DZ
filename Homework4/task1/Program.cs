/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B (и в нулевую степень). Использовать свои функции, не использовать Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

double Power(double a, int b)
{
    int i=1;
    double p = a;
    if (b==0)
    {
        return 1;
    }
    else
    {
        while (i<b)
        {
            p = p * a;
            i++;
        }
        return p;
    }
}

Console.WriteLine("Введите число А: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Power(A,B)}");