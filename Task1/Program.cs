﻿// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет
using System;

Console.WriteLine("Введите первое число:");
string? numberStringOne = Console.ReadLine();

Console.WriteLine("Введите второе число:");
string? numberStringTwo = Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);
int numberIntTwo = Convert.ToInt32(numberStringTwo);

if (numberIntOne * numberIntOne == numberIntTwo)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

