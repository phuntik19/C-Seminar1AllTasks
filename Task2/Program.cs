// 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее. 
// a = 5, b = 7 -> max = 7, min = 5
// a = 2, b = 10 -> max = 10, min = 2
// a = -9, b = -3 -> max -3, min = -9
// a = 3, b = 3, числа равны
using System;

Console.WriteLine("Введите первое число:");
string? numberStringOne = Console.ReadLine();

Console.WriteLine("Введите второе число:");
string? numberStringTwo = Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);
int numberIntTwo = Convert.ToInt32(numberStringTwo);

if (numberIntOne < numberIntTwo)
{
    Console.WriteLine("Числа равны");
}
    
 else if (numberIntOne > numberIntTwo)
{
    Console.WriteLine("?");
}

else
{
   Console.WriteLine("числа равны");
}
   
