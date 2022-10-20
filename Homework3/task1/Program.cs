/*Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
Не применять строки!
14212 -> нет
12821 -> да
23432 -> да*/

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Введите пятизначное число: ");
if (number>9999&number<100000)
{
    if (number/10000==number%10 & (number/1000)%10==(number%100)/10)
    {
        Console.WriteLine("палиндром");
    }
    else
    {
        Console.WriteLine("не палиндром");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}
