
int[,] CreateTwoDimensionArrayInt(int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

void PrintArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (i == j)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }

    }
    Console.WriteLine();
    Console.WriteLine("Result of this task is following:");
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива

void Seminar_8_Tasks_54()
{
    int[,] temp = CreateTwoDimensionArrayInt(4, 4);
    Console.WriteLine("Initial array is:");
    PrintArrayInt(temp);
    SortToLower(temp);
    PrintArrayInt(temp);
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Seminar_8_Tasks_56()
{
    Console.Write("Please fill in first dimention:");
    int l = int.Parse(Console.ReadLine());
    Console.Write("Please fill in second dimention:");
    int c = int.Parse(Console.ReadLine());
    int[,] array = new int[l, c];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (i == j)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

    int minRowSum = int.MaxValue, indexMinRow = 0;
    for (int i = 0; i < l; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < c; j++)
            rowSum += array[i, j];

        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            indexMinRow = i;
        }
    }
    Console.Write("Line with minimal sum is: ");
    for (int j = 0; j < c; j++)
        Console.Write(array[indexMinRow, j] + " ");
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void Seminar_8_Tasks_58()
{
    int[,] FirstArray = CreateTwoDimensionArrayInt(4, 4);
    Console.WriteLine("First Two Dimension Array is: ");
    PrintArrayInt(FirstArray);
    Console.WriteLine();
    int[,] SecondArray = CreateTwoDimensionArrayInt(4, 4);
    Console.WriteLine("Second Two Dimension Array is: ");
    PrintArrayInt(SecondArray);
    int[,] MultyArray = new int[4, 4];

    if (FirstArray.GetLength(0) != SecondArray.GetLength(1))
    {
        Console.WriteLine(" It is impossible to multiply ");
        return;
    }
    for (int i = 0; i < FirstArray.GetLength(0); i++)
    {
        for (int j = 0; j < SecondArray.GetLength(1); j++)
        {
            MultyArray[i, j] = 0;
            for (int k = 0; k < FirstArray.GetLength(1); k++)
            {
                MultyArray[i, j] += FirstArray[i, k] * SecondArray[k, j];
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("Result is:");
    PrintArrayInt(MultyArray);
}



Seminar_8_Tasks_54();
//Seminar_8_Tasks_56();
//Seminar_8_Tasks_58();