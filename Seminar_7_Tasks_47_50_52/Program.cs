
double[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
    double[,] array = new double[firstLength, secondLength];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().NextDouble() * 100;

    return array;
}

void PrintArray(double[,] array)
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
            Console.Write($"{array[i, j]:F2} ");
        }
        Console.WriteLine();
    }
}

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

void anArrayElement()
{
    Console.Write("Please fill  in 1st dimention's meaning: ");
    int c = int.Parse(Console.ReadLine());

    Console.Write("Please fill  in 1st dimention's meaning: ");
    int d = int.Parse(Console.ReadLine());

    int[,] array = new int[c, d];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }

    Console.Write("Please fill  in 1st element: ");
    int a = int.Parse(Console.ReadLine()) - 1;
    Console.Write("Please fill  in 2nd element: ");
    int b = int.Parse(Console.ReadLine()) - 1;
    if (a > c && b > d)
        Console.WriteLine("такого числа нет");
    else
    {
        object r = array.GetValue(c, d);
        Console.WriteLine(r);
    }


}

void ArithmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Arithmetic mean of {j + 1} column is: {sum / array.GetLength(0)} ");
    }
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

void Seminar_7_Tasks_47()
{
    PrintArray(CreateTwoDimensionArray(10, 5));
}


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void Seminar_7_Tasks_50()
{
    Console.Write("Please fill inn Array's first dimention: ");
    int first = int.Parse(Console.ReadLine());
    Console.Write("Please fill inn Array's second dimention: ");
    int second = int.Parse(Console.ReadLine());

    int[,] array = new int[first, second];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 100);
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}  ");
        Console.WriteLine();
    }

    Console.Write("Please identify coordinate 1: ");
    int a = int.Parse(Console.ReadLine()) - 1;
    Console.Write("Please identify coordinate 2: ");
    int b = int.Parse(Console.ReadLine()) - 1;

    if (a > (first - 1) && b > (second - 1))
    {
        Console.WriteLine("There is no such element");
    }

    else
    {
        object result = array.GetValue(a, b);
        Console.Write($"The meaning of this element is: {result}");
    }

}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void Seminar_7_Tasks_52()
{
    PrintArrayInt(CreateTwoDimensionArrayInt(5, 5));
    ArithmeticMean(CreateTwoDimensionArrayInt(5, 5));
}

//Seminar_7_Tasks_47();
//Seminar_7_Tasks_50();
Seminar_7_Tasks_52();




