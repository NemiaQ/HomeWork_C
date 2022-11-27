// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreatRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++) array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void SortMaxMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreatRandom2Array(m, n, min, max);
Show2Array(myArray);
SortMaxMin(myArray);
Console.WriteLine("New array:");
Show2Array(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreatRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++) array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int FindMinRow(int[,] array)
{
    int minSum = 0, minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0)
            minSum = sum;
        else if (minSum > sum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow;
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreatRandom2Array(m, n, min, max);
Show2Array(myArray);
Console.WriteLine($"The row with the smallest sum is: {FindMinRow(myArray)}");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreatRandom2Array(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++) array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] array1, int[,] array2)
{

    int[,] resultArray = new int[array2.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                resultArray[i, j] += (array1[i, k] * array2[k, j]);
            }
        }

    }
    return resultArray;
}

Console.Write("Input a number of rows in the first array: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns in the first array: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of rows in the second array: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns in the second array: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray1 = CreatRandom2Array(m1, n1, min, max);
Console.WriteLine("The first array:");
Show2Array(myArray1);

int[,] myArray2 = CreatRandom2Array(m2, n2, min, max);
Console.WriteLine("The second array:");
Show2Array(myArray2);

if (myArray1.GetLength(1) == myArray2.GetLength(0))
{
    Console.WriteLine("Result of multiplication of array:");
    Show2Array(MultiplyMatrix(myArray1, myArray2));
}
else Console.WriteLine("The number of columns in the first array must match the number of rows in the second array!!!");
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreatRandom3Array(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                while (array[i, j, k] == 0)
                {
                    int num = new Random().Next(10, 100);
                    if (NumCheck(array, num) == true)
                        array[i, j, k] = num;
                }
            }
        }
    }
    return array;
}

bool NumCheck(int[,,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == 0)
                    return true;
                if (array[i, j, k] == num)
                    return false;
            }
        }
    }
    return true;
}

void Show3Array(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }

        }
        Console.WriteLine();
    }
}

Console.Write("Input the first value for the array: ");
int one = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second value for the array: ");
int two = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third value for the array: ");
int three = Convert.ToInt32(Console.ReadLine());

if (one * two * three > 90) Console.WriteLine("The product of the entered values must be less than 91!");
else
{
    int[,,] myArray = CreatRandom3Array(one, two, three);
    Show3Array(myArray);
}
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int[,] CreatRandom2Array(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int value = 1;

    for (int i = 0; i < rows && i < columns; i++)
    {
        for (int j = i; j < columns; j++)
        {
            if (array[i, j] == 0)
            {
                array[i, j] += value;
                value++;
            }
        }
        for (int k = i, j = columns - 1; k < rows; k++)
        {
            if (array[k, j] == 0)
            {
                array[k, j] += value;
                value++;
            }
        }
        for (int k = rows - 1, j = columns - 1; j >= i; j--)
        {
            if (array[k, j] == 0)
            {
                array[k, j] += value;
                value++;
            }
        }
        for (int k = rows - 1, j = i; k >= i; k--)
        {
            if (array[k, j] == 0)
            {
                array[k, j] += value;
                value++;
            }
        }
        rows--;
        columns--;
    }
    return array;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string result = String.Format("{0:d2}", array[i, j]);
            Console.Write(result + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreatRandom2Array(m, n);
Show2Array(myArray);
*/