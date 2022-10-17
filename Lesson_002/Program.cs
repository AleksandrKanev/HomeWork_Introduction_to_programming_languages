// Задача 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int CutDigit(int number)
{
    int ed = number % 10;
    int sot = number / 100;

    int result = sot * 10 + ed;
    return result;
}

int randNum = new Random().Next(100, 1000);
int newNum = CutDigit(randNum);

Console.WriteLine($"New version of {randNum} is {newNum}");
*/

// Задача 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int MaxNum(int number)
{
    int ed = number % 10;
    int des = number / 10;
    int max = ed;
    if(max < des) max = des;
    return max;
}

int randNum = new Random().Next(10, 100);
int maxN = MaxNum(randNum);

Console.WriteLine($"Biggest digit of {randNum} is {maxN}");
*/
// Задача 3. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

bool Square(int n1, int n2)
{
    if(n1 == n2 * n2 || n2 == n1 * n1)
    {
        return true;
    }
    return false;
}

bool result = Square(n1, n2);

Console.WriteLine(result);
*/

// Задача 4. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

bool multiple(int n1, int n2)
{
    if(n2 % n1 == 0)
    {
        return true;
    }
    return false;
}

bool result = multiple(n1, n2);

Console.WriteLine(result);



