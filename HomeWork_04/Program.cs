// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Power(int num1, int num2)
// {
//     int result = 1;
//     for (int i = 1; i <= num2; i++)
//         result *= num1;
//     return result;
// }

// Console.Write("Input the first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num1} в степени {num2} равно: {Power(num1, num2)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Sum (int number)
// {
//     int result = 0;
    
//     while (number > 0)
//     {
//         result += number%10;
//         number/= 10;
//     }
//     return result;
// }

// Console.Write("Input the a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр в числе {number} равна: {Sum(number)}");

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] CreatArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write($"{array[i]} ");
    
//     Console.WriteLine();
// }

// PrintArray(CreatArray(8,1,100));
