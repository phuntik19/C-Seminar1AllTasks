// 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
// 5 -> 2,4
// 8 -> 2,4,6,8 
Console.WriteLine("Введите число N");
string? n =  Console.ReadLine();
int b = Convert.ToInt32(n);
for (int i = 1; i<=b; i++)
if (i% 2 == 0)
{
    Console.WriteLine(i);
}