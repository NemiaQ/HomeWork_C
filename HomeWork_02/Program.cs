// ДЗ 2

/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int CutNumber(int number)
{
    number = number / 10 % 10;
    return number;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = CutNumber(num);
Console.WriteLine($"Второй цифрой числа {num} является {result}");
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int ThirdDigit(int number)
{
    if (number > 99)
    {
        number = number / 100 % 10;
        return number;
    }
    else
        return -1;
}

void WriteResult(int number, int result)
{
    if (result == -1)
        Console.WriteLine("Третьей цифры нет.");
    else
        Console.WriteLine($"Третьей цифрой числа {number} является {result}.");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = ThirdDigit(number);
WriteResult(number, result);
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int ThirdDigit(int number)
{
    if(number < 100)
        return -1;

    else
    {
        while (number >= 1000)
        {
            number /= 10;
        }
        return number % 10;
    }
}

void WriteResult(int number, int result)
{
    if (result == -1)
        Console.WriteLine("Третьей цифры нет.");
    else
        Console.WriteLine($"Третьей цифрой числа {number} является {result}.");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = ThirdDigit(number);
WriteResult(number, result);
*/

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
string Weekend(int number)
{
    if (number == 6 || number == 7)
        return "Да";
    if (number > 0 && number < 6)
        return "Нет";
    else
        return "Введен неверный день недели.";
}
Console.Write("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Weekend(number));
*/