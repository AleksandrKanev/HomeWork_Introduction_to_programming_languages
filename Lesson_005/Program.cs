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

// int GetNegativSum(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//         if(array[i] < 0)
//             sum += array[i];
//     return sum;
// }


// Console.WriteLine("Input number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size);
// ShowArray(myArray);

// int negativeSum = GetNegativSum(myArray);

// Console.WriteLine("Sum of negativ elements is " + negativeSum);

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size]; // шаблон запомнить

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1,100);
//     }

//     return array;
// }

// bool IsFindnumber(int [] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == number) return true;
//     }
//     return false;
// }

// Console.WriteLine("Input numbers: ");
// int num = Convert.ToInt32(Console.ReadLine());

// IsFindnumber(myArray, num);

// Console.WriteLine(IsFindnumber(myArray, num));

// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

// Console.WriteLine("Input max numbers: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min numbers: ");
// int num2 = Convert.ToInt32(Console.ReadLine());


// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

