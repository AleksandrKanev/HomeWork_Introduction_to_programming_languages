// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int DigitSecond (int number)
{
    if(999 > number && number >100)
    {
        int n = number % 100  / 10;
        return n;
    }
    else 
    {
        int n = -1;
        return n;
    }
}

Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = DigitSecond(num);
if(num1 >= 0)
{
    Console.WriteLine($"The digit is equal to {num1}");
}
else
{
    Console.WriteLine("You entered a non-three-digit number!!");
}

*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int Del (int number)
{

    int del = 1;
    
    while(number / del > 0)
    {
        del = del * 10;
    }     
    return del;
    
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());


if(num > 99)
{
    int n1 = num / (Del (num) / 1000) % 10;
    Console.WriteLine($"The third digit of the number {num} is equal to {n1}");
    Console.WriteLine(Del (num));
}
else
{
    Console.WriteLine("There are no third digits");
}
*/



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 1 && num < 6 || num > 7)
{
    Console.WriteLine("This day is not a day off");
}

if(num >= 6 && num <= 7)
{
    Console.WriteLine("This day is a day off");
}