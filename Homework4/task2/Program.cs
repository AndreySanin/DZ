/*Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
Функция должна на вход принимать число, а выдавать сумму его цифр
452 -> 11
82 -> 10
9012 -> 12*/

int Prompt(string message)
{
    Console.Write(message);
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return number;
}

int Digits_sum(int number)
{
    int sum = 0;
    while(Convert.ToString(number).Length>0&number!=0)
    {
        sum=sum+number%10;
        number=number/10;
    }
    return sum;
}

int Number=Prompt("Введите число: ");
Console.WriteLine($"{Digits_sum(Number)}");