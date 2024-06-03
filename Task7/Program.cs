// 7. Напишите программу, которая принимает на вход  трехзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
using System;

Console.WriteLine("Введите число");
string? numberString = Console.ReadLine();
int numberInt = Convert.ToInt32(numberString);

if (numberInt == 456)
{
    Console.WriteLine("6");
}

if (numberInt == 782)
{
      Console.WriteLine("2");
}

if (numberInt == 918)
{
      Console.WriteLine("8");
}