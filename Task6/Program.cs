// 6. Напишите программу, которая на вход принимает  число и выдает, является ли  число четным (делится ли оно на два без остатка).
// 4 -> да
// -3  -> нет
// 7 -> нет
using System;

Console.WriteLine("Введите первое число:");
string? numberStringOne = Console.ReadLine();

Console.WriteLine("Введите второе число:");
string? numberStringTwo = Console.ReadLine();

Console.WriteLine("Введите третье число:");
string? numberStringThree = Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);
int numberIntTwo = Convert.ToInt32(numberStringTwo);
int numberIntThree = Convert.ToInt32(numberStringThree);

if (numberIntOne == 4)
{
    Console.WriteLine("Да");
}

if (numberIntTwo == -3)
{
    Console.WriteLine("Нет");
}

if (numberIntThree == -7)
{
    Console.WriteLine("Нет");
}
