// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

void Show2dArray(int[,] array)
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



// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// int[,] myArray1 = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// Show2dArray(myArray1);
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] RegArray(int[,] array)
// {
//     int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, j] < array[i, k])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = temp;
//                 }

//             }
//             newArray[i, j] = array[i, j];
//         }

//     }
//     return newArray;
// }

// int[,] myArrayNew = RegArray(myArray);
// Show2dArray(myArrayNew);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// void RowsMinSum(int[,] array)
// {
//     int min = 0;
//     int sumMin = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         if (sumMin == 0) sumMin = sum;
//         if (sumMin > sum) min = i;

//     }
//     Console.WriteLine($"Наименьшая сумма элементов в строке {min}");

// }

// RowsMinSum(myArray);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] MultiplyArrays(int[,] array2, int[,] array3)
// {
//     int[,] multiArray = new int[array2.GetLength(0), array3.GetLength(0)];
//     {
//         for (int i = 0; i < array2.GetLength(0); i++)
//         {

//             for (int j = 0; j < array3.GetLength(1); j++)
//             {

//                 for (int k = 0; k < array2.GetLength(0); k++)
//                 {

//                     multiArray[i, j] += array2[i, k] * array3[k, j];

//                 }


//             }

//         }
//         return multiArray;
//     }
// }
// void MultiShow2dArray(int[,] array, int[,] array1, int[,] array3)
// {

//     if (array.GetLength(0) == array1.GetLength(1))
//         Show2dArray(MultiplyArrays(array, array1));

//     else
//     {
//         Console.WriteLine("Умножение матриц невозможно! Число столбцов в первом сомножителе не равно числу строк во втором.");
//     }
// }
// int[,] myArray2 = MultiplyArrays(myArray, myArray1);

// MultiShow2dArray(myArray, myArray1, myArray2);



// Show2dArray(MultiplyArrays(myArray, myArray1));
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] CreateRandom3dArray(int rows, int columns, int stratum)
// {
//     int[,,] array3d = new int[rows, columns, stratum];
//     int[] array = new int[rows * columns * stratum];
//     for (int x = 0; x < array.Length; x++)
//     {
//         array[x] = new Random().Next(10, 100);
//         // Console.WriteLine(array[x]);
//         for (int n = x - 1; n >= 0; n--)
//         {
//             if (array[x] == array[n])
//             {
//                 array[x] = new Random().Next(10, 100);
//                 // Console.Write(array[x]);
//                 n = x - 1;
//             }
//         }

//     }
//     int c = 0;

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             for (int k = 0; k < stratum; k++)
//             {
//                 array3d[i, j, k] = array[c];
//                 c++;


//             }

//         }
//     }
//     return array3d;
// }



// void Show3dArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write(array[i, j, k] + $"({i},{j},{k})  ");
//             }
//             Console.WriteLine();
//         }
//     }
// }



Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of stratum: ");
// int o = Convert.ToInt32(Console.ReadLine());



// int[,,] myArray = CreateRandom3dArray(m, n, o);
// Show3dArray(myArray);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[] Array(int m, int n)
{
    int[] array = new int[m * n];
    for (int x = 0; x < array.Length; x++)
    {
        array[x] = new Random().Next(10, 100);
        Console.Write(array[x] + ",  ");
    }
    Console.WriteLine();
    return array;
}
int[] array3 = Array(m, n);

int[,] SpiralArray(int[] array, int m, int n)
{
    int[,] array2d = new int[m, n];
    int index = 1;
    int a = 0;
    int b = 0;
    int x = 0;
    int y = 0;
    array2d[0, 0] = array[0];
    while (index < array.Length)
    {
        for (int j = b + 1; j < array2d.GetLength(0) - x; j++, index++)
        {
            array2d[a, j] = array[index];
            Console.WriteLine(array2d[a, j]);
            b = j;
        }

        for (int i = a + 1; i < array2d.GetLength(1) - y; i++, index++)
        {
            array2d[i, b] = array[index];
            Console.WriteLine(array2d[i, b]);
            a = i;
        }
        for (int j = b - 1; j >= x; j--, index++)
        {
            array2d[a, j] = array[index];
            Console.WriteLine(array2d[a, j]);
            b = j;
        }
        y++;
        for (int i = a - 1; i >= y; i--, index++)
        {
            array2d[i, b] = array[index];
            Console.WriteLine(array2d[i, b]);
            a = i;
        }
        x++;

    }
    return array2d;
}

int[,] myArray = SpiralArray(array3, m, n);


Show2dArray(myArray);

