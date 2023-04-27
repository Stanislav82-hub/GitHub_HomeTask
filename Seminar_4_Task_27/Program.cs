// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.Write("Hello, give me a number \t");
int number = int.Parse(Console.ReadLine());

string text = number.ToString();
int[] array = new int[text.Length];
for (int i = 0; i < text.Length; i++)
{
    array[i] = int.Parse(text[i].ToString());
}

int sum = 0;
int count = 0;
while (count <= array.Length - 1)
{
    sum = sum + array[count];
    count++;
}
Console.Write("Summ of all digits in this number is " + sum);