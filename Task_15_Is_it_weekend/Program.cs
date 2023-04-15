// Напишите программу, которая принимает на вход цифру, обозначающую день недели
// и проверяет, является ли этот день выходным
Console.WriteLine("Please fill in week's day number:");
int number = int.Parse(Console.ReadLine());
if(number < 6) 
{
    Console.WriteLine("It is not a weekend");
}
else
{
    Console.WriteLine("It is a weekend");
}