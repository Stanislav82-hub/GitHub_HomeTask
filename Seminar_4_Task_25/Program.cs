// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

int FillInNumber()
{
    Console.Write("Hello, give me a number please \t");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Result(int a, int b)
{
    int degree = 1;
    int result = a;
    while (degree <= b-1)
    {
        result = result * a;
        degree++;
    }
    return result;
}

int a = FillInNumber();
int b = FillInNumber();
Result( a, b);

Console.Write(Result(a, b));
