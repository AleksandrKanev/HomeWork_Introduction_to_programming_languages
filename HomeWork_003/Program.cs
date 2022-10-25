// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void Palindrom(int number)
// {
//     int del = 10;
//     int del1 = 1;
//     int newNum = 0;
//     int n = number;
//     int count = number;
//     while (count > 0)
//     {
//         n = number % del / del1;
        
//         del = del * 10;
//         del1 = del1 *10;

//         newNum = newNum * 10 + n;
//         count = count / 10;
//         // Console.WriteLine(newNum);
//     }

    
   
//     if(number == newNum) Console.WriteLine($"Цифра {number} является палиндромом!");
//     else Console.WriteLine($"Цифра {number} не является палиндромом!");
// }

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Palindrom(num);


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// double Point(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double ab = Math.Sqrt((x1-x2) * (x1-x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
//     return ab;
// }

// Console.Write("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Расстояние между точками равно {Point(x1, y1, z1, x2, y2, z2)}");


// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void square(int number)
{
    for (int i = 1; i <= number; i++)
    {
        int n = i * i;

        Console.Write($"{n}, ");
    }
} 
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

square(num);
