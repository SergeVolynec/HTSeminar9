Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= 0)
{
    Console.WriteLine ("Число должно быть больше 0!");
    return;
}

/// <summary>
/// Печатает числа в обратоном порядке в диапазоне от первого аргумента до второго
/// </summary>
/// <param name="start">Начальное число</param>
/// <param name="end">Конечное число</param>
/// <returns></returns>
string PrintNumbers(int start, int end)
{
    if (start == end) return end.ToString();
    return (start + ", " + PrintNumbers(start - 1, end));
}

Console.WriteLine(PrintNumbers(N, 1));