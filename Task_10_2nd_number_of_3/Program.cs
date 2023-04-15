//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Please fill in three-digit number:");
int number = int.Parse(Console.ReadLine());
int a = number / 10;
Console.WriteLine(a);
int result = a % 10;
Console.WriteLine($"Second digit is {result}");