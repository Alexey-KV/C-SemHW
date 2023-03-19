// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да, 23432 -> да.

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string Palindrome(int a, int b, int c, int d, int e)
{
    string result = "";
    if(a == e && b == d)
    {
        result = "Число является палиндромом";
    }
    else
    {
        result = "Число не является палиндромом";
    }
    return result;
}

int A = Prompt("Введите 1 цифру пятизначного числа: ");
int B = Prompt("Введите 2 цифру пятизначного числа: ");
int C = Prompt("Введите 3 цифру пятизначного числа: ");
int D = Prompt("Введите 4 цифру пятизначного числа: ");
int E = Prompt("Введите 5 цифру пятизначного числа: ");

string palindrome = Palindrome(A, B, C, D, E);
Console.WriteLine(palindrome);

// sorry не было временни придумать нормальный ввод (были бы знания, времени было бы не нужно)) 
