﻿// Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumScore(int n)
{
    if (n == 1)
        return "1";
    {
        return n + " " + NumScore(n - 1);
    }
}
Console.Clear();
Console.Write("Введите число N: ");
int num = int.Parse(Console.ReadLine()!);
string x = NumScore(num);
Console.WriteLine(x);
