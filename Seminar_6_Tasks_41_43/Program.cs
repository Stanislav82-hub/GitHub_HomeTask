int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            count += 1;
        else count += 0;

    return count;
}


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Seminar_6_Tasks_41()
{
    int index = 10;
    int[] array = new int[index];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Give me a {i + 1} array element, please: \t");
        array[i] = int.Parse(Console.ReadLine());
    }
   
    Console.Write($"There are {CountNumbers(array)} numbers above 0");
}


Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

//Seminar_6_Tasks_41();