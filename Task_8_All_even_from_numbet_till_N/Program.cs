// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
//Console.WriteLine("Please fill in any number:");
//int number = int.Parse(Console.ReadLine());

//Console.WriteLine("Hello, World!");
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
for(int i=1;i<=n;i++)
{
if (i % 2 == 0)
System.Console.Write(i + ", ");
}