// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] CreateRandomArray( int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // шаблон запомнить

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }

    Console.WriteLine();
}

void ReverseArray (int[] array)
{
    for (int i = 0, j = array.Langth; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}


Console.WriteLine("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(8,0,1);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

int[] GitFib(int size, int a, int b)
{
    int[] array = new int[size];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
} 



// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] GetArrayCopy(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}


// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

bool IsTriangle(int a, int b, int c)
{
    if(a + b > c && a + c > b && c + b > a)
        return true;
    return false;
}