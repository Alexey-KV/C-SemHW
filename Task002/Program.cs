﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Please enter the number (A): ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the number (B): ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    Console.Write($"number A ({numberA}) > number B ({numberB})");
}
else
{
    Console.Write($"number A ({numberA}) < number B ({numberB})");
}