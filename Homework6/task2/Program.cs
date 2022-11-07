/*Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void CrossPoint(int k1, int b1, int k2, int b2)
{
    double x = Convert.ToDouble(b2-b1)/Convert.ToDouble(k1-k2);
    double y = k1*x+b1;
    Console.WriteLine($"({x}; {y})");
}

int k1 = Prompt("k1: ");
int b1 = Prompt("b1: ");
int k2 = Prompt("k2: ");
int b2 = Prompt("b2: ");
CrossPoint(k1,b1,k2,b2);