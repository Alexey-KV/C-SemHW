// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Please enter the number (A): ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the number (B): ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the number (C): ");
int numberC = Convert.ToInt32(Console.ReadLine());

int maxNumber = numberA;

if(maxNumber < numberC)
{
    maxNumber = numberC;
    Console.Write($"Maximum number is C ({numberC})");
}
else if(maxNumber < numberB)
{
    Console.Write($"Maximum number is B {numberB}");
}
else
{
    Console.Write($"Maximum number is A {numberA}");
}



