// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
// Дембельский аккорд на курсе :-)

Console.Write("Введите число N: ");
var nValue = Convert.ToInt32(Console.ReadLine());

int offsetX = 4; // задаем интервал между символов
int offsetY = Console.CursorTop; // задаем начальную точку


int Factorial(int n)
{
    if (n == 0) return 1;
    return n * Factorial(n - 1);
}

// вычисление элемента треугольника
int GetPoint(int n, int m)
{
    return Factorial(n) / (Factorial(m) * Factorial(n - m));
}

// генерируем данные для треугольника
int[,] GenTriangleData(int n)
{
    int[,] result = new int[n, n + 1];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < i + 1; j++)
        {
            result[i, j] = GetPoint(i, j);
        }

    }
    return result;
}


// печатаем треугольник
void PrintTriangle(int[,] triangleData, int startPoint, int level = 0, int pos = 0)
{
    /*
    Прямо как в старом меме:
     ▲
    ▲ ▲ Newfags can't triforce!
    немного криво при выводе двух, четырех-значных чисел
    */
    if (level == triangleData.GetLength(0)) return;
    if (pos < triangleData.GetLength(1))
    {
        if (triangleData[level, pos] != 0)
        {
            int xPos = startPoint;
            if(triangleData[level, pos] > 99) // немного выравниваем вывод
                xPos--;
            Console.SetCursorPosition(xPos, level + offsetY);
            Console.Write(triangleData[level, pos]);
        }
        PrintTriangle(triangleData, startPoint - offsetX, level + 1, pos);
        PrintTriangle(triangleData, startPoint + offsetX, level + 1, pos + 1);
    }
}

PrintTriangle(GenTriangleData(nValue), Console.WindowWidth / 2);