// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// void FindMore(int numbers)
// {
//     int current = 0;
//     for (int i = 0; i < numbers; i++)
//     {
//         Console.WriteLine("Input number: ");
//         int count = Convert.ToInt32(Console.ReadLine());
//         if (count > 0) current++;

//     }
//     Console.WriteLine($"The number of values greater than zero is equal to {current}");

// }

// Console.WriteLine("How many values do you want to enter?");
// int n = Convert.ToInt32(Console.ReadLine());

// FindMore(n);

//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Intersection(int k1, int b1, int k2, int b2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2) Console.WriteLine("Прямые паралельны!");

    else if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают!");

    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"Пересечение прямых в точке({x}, {y})");
    }
}

    Console.Write("Ведите переменную k1: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите переменную b1: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите переменную k2: ");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите переменную b2: ");
    int d = Convert.ToInt32(Console.ReadLine());

    Intersection(a, b, c, d);
