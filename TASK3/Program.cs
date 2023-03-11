Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber < 0 || secondNumber < 0) 
{
    Console.WriteLine ("Числа должны быть положительными!");
    return;
}

/// <summary>
/// Высчитывает функцию Аккермана для заданных чисел
/// </summary>
/// <param name="n">Первый параметр</param>
/// <param name="m">Второй параметр</param>
/// <returns></returns>
int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Akkerman(n - 1, 1);
    else return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.WriteLine(Akkerman(firstNumber, secondNumber));