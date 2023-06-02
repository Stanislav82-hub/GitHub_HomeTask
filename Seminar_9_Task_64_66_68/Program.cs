// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурсии.
void PrintNumber(int number)
{
    if (number != 0)
    {
        PrintNumber(number - 1);
    }
    System.Console.Write($"{number} ");
}

//PrintNumber(5);

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в
// промежутке от M до N.
int SumElements(int number_1, int number_2)
{
    int sum = number_1;

    if (number_1 < number_2)
    {
        
        sum = number_1 + SumElements(number_1+1, number_2);

    }
    return sum;
}

//System.Console.WriteLine(SumElements(1, 4));


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
//неотрицательных числа m и n.

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("Result is " + Akkerman(2, 3));