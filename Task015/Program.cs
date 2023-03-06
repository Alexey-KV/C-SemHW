// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Please enter the number of the day of the week (1 - 7): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 6)
{
    Console.Write("You entered a working day number");
}
else if (number == 6 || number == 7)
{
    Console.Write("You entered a holyday number");
}
else
{
    Console.Write("Invalid number");
}
