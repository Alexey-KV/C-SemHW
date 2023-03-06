// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

Console.Write("Please enter a three-digit number (A): ");
int number = Convert.ToInt32(Console.ReadLine());
int digit3 = number / 10;
int digit2 = digit3 % 10;

if (digit2 < 0)
{
    digit2 = digit2 * -1;
}

Console.WriteLine($"Second digit of the number (A) is {digit2}");
