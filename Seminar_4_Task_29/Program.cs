// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] RandomArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
        array[i] = (new Random().Next(0, 100));
    return array;
}
Console.Write("Fill in number \t");
int number = int.Parse(Console.ReadLine());
Console.Write("Your random array is: "+String.Join(", ", RandomArray(number)));
