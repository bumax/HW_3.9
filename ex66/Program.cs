// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите начало диапазона: ");
var m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
var n = new int();
do
{
    n = Convert.ToInt32(Console.ReadLine());
} while (n < m);

int GetSum(int start, int finish)
{
    if (start == finish) return finish;
    return start + GetSum(start + 1, finish);
}

Console.WriteLine($"Сумма элементов в диапазоне от {m} др {n} равна {GetSum(m, n)}");