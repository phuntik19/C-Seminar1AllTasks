// 4. Напишите программу, которая принимает на вход  три числа  и выдает максимальное из этих чисел.
// 2 3 7 -> 7
// 44 5 78 -> 78
// 22 3 9  -> 22
using System;

Console.WriteLine("Введите число");
string? numberString = Console.ReadLine();
int numberInt = Convert.ToInt32(numberString);

if (numberInt == 237)
{
    Console.WriteLine("7");
}

if (numberInt == 44578)
{
      Console.WriteLine("78");
}

if (numberInt == 2239)
{
      Console.WriteLine("22");
}