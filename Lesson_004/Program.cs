// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int FindeSum(int number)
// {
//     int sum = 0;

//     for (int current = 0; current <= number; current++)
//     {
//         sum += current;
//     }

//     return sum;

// }

// Console.Write("Input a numer: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Sum of number from 1 to {a} is {FindeSum(a)}");

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int CountDigit(int number)
// {
//     int count = 0;

//     while (number != 0)
//     {
//         number /= 10;
//         count++;
//     }
//     return count;
// }

// Console.Write("Input a numer: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"The number of digits is {CountDigit(num)}");

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int Fact(int number)
// {
//     int mul = 1;

//     for (int current = 1; current <= number; current++)
//     {
//         mul *= current;
//     }

//     return mul;

// }

// Console.Write("Input a numer: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Factorial of {a} is {Fact(a)}");

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// int[] CreateRandomArray( int size, int minValue, int maxValue)
// {
//     int[] array = new int[size]; // шаблон запомнить

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }

//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }

//     Console.WriteLine();
// }

// Console.WriteLine("Input number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(8,0,1);
// ShowArray(myArray);

// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// int[] CreateRandomArray( int size)
// {
//     int[] array = new int[size]; // шаблон запомнить

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-100, 101);
//     }

//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }

//     Console.WriteLine();
// }

// Console.Write("Input number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(n);
// ShowArray(myArray);


// Здесь написать программу, которая запрашивает размер и каждый элемент по одельности у пользователя. 

int[] CreateRandomArray( int size)
{
    int[] array = new int[size]; // шаблон запомнить

    for (int i = 0; i < size; i++)
    {
        Console.Write("Input number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        array[i] = a;
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
