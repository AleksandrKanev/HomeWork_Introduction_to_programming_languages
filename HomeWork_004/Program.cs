// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int ADegreeB (int a, int b)
// {
//     int n = a;
//     if (b == 0) return 1;
//     else
//         for (int i = 2; i <= b; i++)
//         {
//             n = n * a; 
//         }
//     return n;
// }

// Console.Write("Input number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(ADegreeB(a, b));



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// void NumSum( int number)
// {
//     int n = 0;
//     int del = 10;
//     int del1 = 1;
//     int num = number;

//     while(number > 0)
//     {
//         n += num % del / del1;
//         del *= 10;
//         del1 *= 10;
//         number /= 10;
//     }
//     Console.WriteLine(n);
// }

// Console.Write("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// NumSum(a);

// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateRandomArray( int size)
{
    int[] array = new int[size]; // шаблон запомнить

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }

    Console.WriteLine();
}

Console.Write("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n);
ShowArray(myArray);