// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum_from_M_to_N(int m, int n)
{
    int num = n;
    if (num < m)
    {
        return 0;
    }
    else
    {
        return num + Sum_from_M_to_N(m, num - 1);
    }
}

int m = Prompt("Введите значение M: ");
int n = Prompt("Введите значение N: ");
System.Console.WriteLine(Sum_from_M_to_N(m, n));