﻿/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/


Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 0)
{
    Console.WriteLine($"{Number} - чётное число");
}
else
{
    Console.WriteLine($"{Number} - нечётное число");
}
