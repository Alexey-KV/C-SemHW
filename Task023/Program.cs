// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Please enter the number (N): ");
int number = Convert.ToInt32(Console.ReadLine());

for( int i = 1; i <= number; i++)//Ex. Цикл через 1: i+=2  <->  i = i + 2
{
   Console.Write($"{Math.Pow(i, 3)} ");
}
