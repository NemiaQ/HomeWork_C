// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int Even(int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0) count++;

//     return count;
// }

// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(n, min, max);
// ShowArray(myArray);
// Console.WriteLine("The number of even numbers is: " + Even(myArray));

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int SumOddPositions(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2) sum += array[i];

//     return sum;
// }

// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandomArray(n, min, max);
// ShowArray(myArray);
// Console.WriteLine("The sum of elements in odd positions is: " + SumOddPositions(myArray));

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] CreatDoubleRandomArray(int size, int minValue, int maxValue)
// {
//     double[] array = new double[size];

//     for (int i = 0; i < array.Length; i++)
//         array[i] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);

//     return array;
// }

// void ShowArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// double DifferenceMaxMin(double[] array)
// {
//     double min = array[0];
//     double max = array[0];

//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < min) min = array[i];
//         if (array[i] > max) max = array[i];
//     }

//     Console.WriteLine($"max: {max} min: {min}");
//     return Math.Round((max - min), 2);
// }

// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[] myArray = CreatDoubleRandomArray(n, min, max);
// ShowArray(myArray);
// Console.WriteLine("The difference between the min and max number is: " + DifferenceMaxMin(myArray));