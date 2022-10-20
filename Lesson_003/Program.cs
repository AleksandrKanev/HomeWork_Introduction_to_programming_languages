// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowQuart(int quartNum)
{
    if(quartNum >= 1 && quartNum <= 4)
    {
        if(quartNum == 1) Console.WriteLine("x > 0 and y > 0");
        else if(quartNum == 2) Console.WriteLine("x < 0 and y > 0");
        else if(quartNum == 3) Console.WriteLine("x < 0 and y < 0");
        else Console.WriteLine("x > 0 and y < 0");
    }
    else 
        Console.WriteLine("Wrong number!");
}

Console.Write("Input a number of quard: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowQuart(num);
*/

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
void quarter(int x, int y)
{
    if(x == 0 && y ==0) Console.WriteLine("Мы на оси координат");
    if(x > 0 && y > 0) Console.WriteLine("Мы в 1 четверти");
    if(x < 0 && y > 0) Console.WriteLine("Мы в 2 четверти");
    if(x < 0 && y < 0) Console.WriteLine("Мы в 3 четверти");
    if(x > 0 && y < 0) Console.WriteLine("Мы в 4 четверти");
}

Console.Write("Введите x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

quarter(x1, y1);
*/
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// double Point(double x1, double y1, double x2, double y2)
// {
//     double ab = x1 - x2;
//     double bc = y1 - y2;
//     double ac = Math.Sqrt(ab*ab + bc*bc);
//     return ac;
// }

// Console.Write("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Расстояние между точками равно {Point(x1, y1, x2, y2)}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void square(int number)
{
    int n = 1;
    while(n <= number)
    {
        int num = n * n;
        n++;
        Console.Write(num + ", ");
    }
}

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

square(num1);