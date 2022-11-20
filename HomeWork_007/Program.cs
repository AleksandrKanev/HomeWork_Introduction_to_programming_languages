// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
            // if (array[i, j] >= 0)
            //     array[i, j] += Math.Round(new Random().NextDouble(), 2); // почему-то иногда не округляет
            // if (array[i, j] < 0)
            //     array[i, j] -= Math.Round(new Random().NextDouble(), 2); // почему-то иногда не округляет
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + ",  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible: ");
int max = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void SearchElement(int n, int m, double[,] array)
{
    if (n <= array.GetLength(0) && n <= array.GetLength(1))
        Console.WriteLine(array[n - 1, m - 1]);
    else
        Console.WriteLine($"Элемента с позицией {n},{m} в данном массиве не существует!");
}
// Console.Write("Введите позицию в строке: ");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию в столбце: ");
// int n1 = Convert.ToInt32(Console.ReadLine());

// SearchElement(m1, n1, myArray);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void MidNum(double[,] array)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write(sum + ", ");
        sum = 0;
    }
}

MidNum(myArray);