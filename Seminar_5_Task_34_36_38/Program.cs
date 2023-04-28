void FillRandomNumber(int[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    PrintArray(array);
}

void FillRandomDouble(double[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble();
    }
    PrintArrayDouble(array);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");

    }
    Console.WriteLine("");
}

void PrintArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");

    }
    Console.WriteLine("");
}

int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int CountNotevenIndex(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (i % 2 == 0)
        {
            count = count + 0;
        }
        else
        {
            count++;
        }

    }
    return count;

}

double Min(double[] array)
{
    double min = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        i = i + 1;

    }
    return min;
}

double Max(double[] array)
{
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        i = i + 1;
    }
    return max;

}

// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
void Seminar5Task34()
{
    int index = 12;
    int[] array = new int[index];

    FillRandomNumber(array);

    Console.WriteLine($"There are {CountEven(array)} even elements in this array");

}

//Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму
//элементов с нечётными индексами.
void Seminar5Task36()
{
    int index = 12;
    int[] array = new int[index];

    FillRandomNumber(array);
    CountNotevenIndex(array);

    Console.WriteLine($"There are {CountNotevenIndex(array)} not even index elements in this array");
}

//Задача 38	Задайте массив вещественных чисел. Найдите разницу между максимальным и
//минимальным элементами массива.
void Seminar5Task38()
{
    int index = 12;
    double[] array = new double[index];

    FillRandomDouble(array);
    Min(array);
    Max(array);
    Console.WriteLine($"Maximum is {Max(array)}");
    Console.WriteLine($"Minimum is {Min(array)}");
    //double result = Max(array) - Min(array);

    Console.WriteLine($"Result is {Max(array) - Min(array)}");
}

//Снимаем комментрарий и "dotnetrun-им": 
Seminar5Task34();
//Seminar5Task36();
//Seminar5Task38();
