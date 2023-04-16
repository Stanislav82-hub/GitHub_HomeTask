// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

<<<<<<< HEAD
Console.WriteLine("Please fill in number N");
=======
Console.WriteLine("Введите число N");
>>>>>>> a8bad1a6736aabe2e64599ca239d7df3c0365c05
int n = int.Parse(Console.ReadLine());
for(int i=1;i<=n;i++)
{
if (i % 2 == 0)
System.Console.Write(i + ", ");
}
