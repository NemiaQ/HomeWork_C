// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNumbers(n - 1);
}

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNumbers(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumOfDigits(int m, int n)
{
    if (m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }

    if (n > m) return SumOfDigits(n - 1, m) + n;
    return n;
}
Console.Write("Input the first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfDigits(m, n));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Input the first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(m, n));
*/