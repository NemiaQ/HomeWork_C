// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int Counter(int number)
// {
//     int count = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         Console.Write("Input a number: ");
//         int value = Convert.ToInt32(Console.ReadLine());
//         if (value > 0) count++;
//     }
//     return count;
// }

// Console.Write("Input number of numbers: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Input values more than 0: {Counter(m)}");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// void Intersection(double k1, double b1, double k2, double b2)
// {
//     if (k1 == k2 && b1 != b2) Console.WriteLine("Lines are parallel.");
//     else if (k1 == k2 && b1 == b2) Console.WriteLine("Lines coincide.");
//     else Console.WriteLine($"Point of intersection of lines: x = {Math.Round(((b2 - b1) / (k1 - k2)),4)}, y = {Math.Round((k1 * ((b2 - b1) / (k1 - k2)) + b1),4)}");
// }
// Console.Write("Input k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// Intersection(k1, b1, k2, b2);
