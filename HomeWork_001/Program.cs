/* Задача №1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int max = n1;
int min = n2;

if(max < n2)
{
    max = n2;
    min = n1;
}

Console.WriteLine($"The number {max} greater than the number {min}");
*/

// Задача №2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if(n2 > max) max = n2;
if(n3 > max) max = n3;

Console.WriteLine($"The maximum number is {max}");
*/

// Задача №3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int remnant = n1 % 2;

if(remnant == 0)
    Console.WriteLine($"The number {n1} is an even number");
else
    Console.WriteLine($"The number {n1} is not an event number");
*/

// Задача №4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int num1 = 1;

while(num1 < n)
{
    int result = num1 % 2;
    if(result == 0)
    {
        Console.WriteLine(num1);
    }
    num1++;
}
 