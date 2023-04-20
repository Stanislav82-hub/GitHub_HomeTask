// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Please fill in number1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please fill in number2");
int number2 = int.Parse(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine($"{number1} is greater than {number2}");
}
else
{
    Console.WriteLine($"Number {number2} is greater than {number1}");
}