// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Please fill in three-digit number:");
int number = int.Parse(Console.ReadLine());
int a = number % 10;
if(number < 100)
{
    Console.WriteLine($"There is no 3rd digit in this number: {number}");
}
else 
{
    if(number >= 1000)
    {
       Console.WriteLine("Please fill in three-digit number:");
    }
    else
    {
        Console.WriteLine($"The 3rd digit of this number is {a}");
    }
        
}
