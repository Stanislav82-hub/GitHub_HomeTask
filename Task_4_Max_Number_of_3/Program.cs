// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Please fill in number1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please fill in number2");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Please fill in number3");
int number3 = int.Parse(Console.ReadLine());

int max = number1;

if(number2 > number1) max = number2;
if(number3 > number2) max = number3;

Console.WriteLine($"The greatest number is {max}");
