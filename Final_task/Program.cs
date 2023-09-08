// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина
// которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

string[] CreateAnitialArray()
{
    Console.Write("How many elements AnitialArray should consist of?:\t");
    int AnitialArrayLenght = int.Parse(Console.ReadLine());
    Console.WriteLine();

    string[] AnitialArray = new string[AnitialArrayLenght];
    for (int i = 0; i < AnitialArray.Length; i++)
    {
        Console.Write($"Please fill in {i + 1} element of AnitialArray :\t ");
        AnitialArray[i] = Console.ReadLine();
    }
    Console.WriteLine();

    Console.WriteLine("AnitialArray consists of following elements:");
    for (int i = 0; i < AnitialArray.Length; i++)
    {
        Console.Write($"{AnitialArray[i]} | ");
    }
    Console.WriteLine();
    Console.WriteLine("========================================================================");
    return AnitialArray;
}

void SecondArrayLength(string[] AnitialArray)
{
    int n = 0;
    for (int i = 0; i < AnitialArray.Length; i++)
    {
        if (AnitialArray[i].Length <= 3)
            n++;
    }

    if (n < 1)
    {
        Console.WriteLine("There are no elements in AnitialArray to include in FinalArray");

    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"Length of FinalArray is {n} elements and they are following:");

        string[] FinalArray = new string[n];


        int j = 0;
        for (int i = 0; i < AnitialArray.Length; i++)
        {
            if (AnitialArray[i].Length <= 3)
            {
                FinalArray[j] = AnitialArray[i];
                j++;
            }
        }

        for (int i = 0; i < FinalArray.Length; i++)
        {
            Console.Write($" {FinalArray[i]} |");
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
    }
    
}

SecondArrayLength(CreateAnitialArray());