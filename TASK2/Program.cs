Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (secondNumber <  firstNumber) 
{
    Console.WriteLine ("Первое число должно быть меньше второго!");
    return;
}

/// <summary>
/// Суммирует числа в диапазоне от первого аргумента до второго
/// </summary>
/// <param name="start">Первое число</param>
/// <param name="end">Второе число</param>
/// <returns></returns>
int SumNumbers(int start, int end)
{
    if (start == end) return end;
    return (start + SumNumbers(start + 1, end));
}

Console.WriteLine(SumNumbers(firstNumber, secondNumber));
