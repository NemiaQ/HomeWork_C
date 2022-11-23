// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// double[,] CreatDoubleRandom2Array(int rows, int columns, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++) array[i, j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);

//     return array;
// }

// void Show2Array(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// double[,] myArray = CreatDoubleRandom2Array(m, n, min, max);
// Show2Array(myArray);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreatRandom2Array(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++) array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2Array(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// void FindNumber(int[,] array, int row, int column)
// {
//     if (row < array.GetLength(0) && column < array.GetLength(1))
//         Console.WriteLine($"row {row}, column {column}: value {array[row, column]}");
//     else
//         Console.WriteLine($"row: {row}, column: {column} - no element");
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a row: ");
// int findRow = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a column: ");
// int findColumn = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreatRandom2Array(m, n, min, max);
// Show2Array(myArray);
// FindNumber(myArray, findRow, findColumn);

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] CreatRandom2Array(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++) array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2Array(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// void ShowArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// double[] Average(int[,] array)
// {
//     double[] averageArray = new double[array.GetLength(1)];

//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         double result = 0;
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             result += array[j, i];
//         }
//         averageArray[i] = Math.Round((result / array.GetLength(0)),2);
//     }
//     return averageArray;
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreatRandom2Array(m, n, min, max);
// Show2Array(myArray);
// ShowArray(Average(myArray));