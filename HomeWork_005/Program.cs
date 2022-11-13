// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] CreateRandomArray( int size)
// {
//     int[] array = new int[size]; // шаблон запомнить

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
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

// void EvenSum(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//         if(array[i] % 2 == 0)
//             sum += 1;
//     Console.WriteLine($"The number of even numbers in the array is {sum}");
// }

Console.WriteLine("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size);
// ShowArray(myArray);
// EvenSum(myArray);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void EleSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if(i % 2 == 0)
            sum += array[i];
    Console.WriteLine($"The sum of the elements standing in odd positions is equal to {sum}");
}

// EleSum(myArray);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray( int size)
{
    double[] array = new double[size]; // шаблон запомнить

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();
    }

    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }

    Console.WriteLine();
}

void Diff(double[] array)
{
    double max = array[0];
    double min = array[1];
    double temp = 0;
    if(min > max)
        temp = max;
        max = min; 
        min = temp;
    for (int i = 2; i < array.Length; i++)
    {
        
        if(max < array[i]) max = array[i];
        if(min > array[i]) min = array[i];
    }
     Console.WriteLine($"The difference between the maximum and minimum array elements is {max - min}");
}

double [] myArray = CreateRandomArray(size);
ShowArray(myArray);
Diff(myArray);