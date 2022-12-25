// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число m: ");
var mValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
var nValue = Convert.ToInt32(Console.ReadLine());

int FunA(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return FunA(m - 1, 1);
    return FunA(m - 1, FunA(m, n - 1));
}

// m = 4, n = 4 - не возвращает, очень большое число :-)
Console.WriteLine(FunA(mValue, nValue));