// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int m, int n)
{
    int num = n;
    if (num < m)
    {
        return;
    }
    else
    {
        if (num % 2 == 0)
        {
            PrintNumbers(m, num - 2);
            System.Console.Write(num + " ");
        }
        else
        {
            num--;
            PrintNumbers(m, num - 2);
            System.Console.Write(num + " ");
        }
    }
}

int m = Prompt("Введите значение M: ");
int n = Prompt("Введите значение N: ");
PrintNumbers(m,n);