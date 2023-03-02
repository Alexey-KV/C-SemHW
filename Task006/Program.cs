// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Please enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int temp = number%2;

if(temp == 0)
{
    Console.Write("Number you entered is even.");
}
else
{
    Console.Write("Number you entered is not even.");
}