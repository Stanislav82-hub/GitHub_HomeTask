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
CreateAnitialArray();