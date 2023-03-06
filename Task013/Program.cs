// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Please enter a number (A): ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = 0;

while (number > 999)
{
number = number / 10;
}
number2 = number % 10;

if(number < 100)
{
    Console.WriteLine("Third digit is missing");
}
else
{
    Console.WriteLine($"Third digit is: {number2}");
}



