/*
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
bool Palindrome(int num)

{
    bool result = true;
    for (int i = 4; num > 10; i -= 2)
    {
        if (num / (Convert.ToInt32(Math.Pow(10, i))) != num % 10)
        {
            result = false;
            break;
        }
        num = num % Convert.ToInt32(Math.Pow(10, i)) / 10;
    }
    return result;
}

void PrintResult(bool result)
{
    if (result == true) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Palindrome(number);

PrintResult(result);
*/

/*
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round((Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2))), 2);
}

Console.Write("Введите координату первой точки по оси Х: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату первой точки по оси Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату первой точки по оси Z: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату второй точки по оси Х: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату второй точки по оси Y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату второй точки по оси Z: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Distance(x1,y1,z1,x2,y2,z2);
Console.WriteLine(distance);
*/

/*
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Cube (int num)

{
    for (int i = 1; i <= num; i++) Console.Write($"{Math.Pow(i,3)} ");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Cube(num);
*/