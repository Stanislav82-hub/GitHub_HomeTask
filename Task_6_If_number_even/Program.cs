//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Please fill in any number:");
int number = int.Parse(Console.ReadLine());

if(number % 2 ==0)
{
    Console.WriteLine("This number is even");
}
else
{
    Console.WriteLine("This number is not even");
}