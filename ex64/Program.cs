// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите число N: ");
var n = Convert.ToInt32(Console.ReadLine());

void GetNums(int number)
{
    if (number == 1)
    {
        Console.Write(1);
        return;
    }
    Console.Write($"{number}, ");
    GetNums(number - 1);
}

Console.Write($"N = {n} -> ");
GetNums(n);