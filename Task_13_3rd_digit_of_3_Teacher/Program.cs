   
// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//int digit = GetDigitfromNumber(ReadInt(), ReadInt());
        
//if (digit != -1)
    //{
    //    Console.WriteLine(digit);
    //}
     //else
   // {
   //     Console.WriteLine("00ps");
  //  }

//int GetDigitfromNumber(int number, int digitPosition)
//{
   // number = Math.Abs(number);
  //  if (number < Math.Pow(10, digitPosition - 1))
//{
 //       return -1; // -1 - эТо ошибка
//    }
//
//  while (number > Math.Pow(10, digitPosition))
    //{
  //      number /= 10;
 //   }
 //   return number % 10;
//}

//int ReadInt()
//{
    //Console.WriteLine("Input number");
    //return int.Parse(Console.ReadLine());
//}

Console.WriteLine("Input number");
int number = int.Parse(Console.ReadLine());
string text = number.ToString();

Console.WriteLine("Input number 2");
int number2 = int.Parse(Console.ReadLine());

int i = number2 - 1;

if(number2 > text.Length)
{
    Console.WriteLine($"There is no digit number {number2}");
}
else 
{
    Console.WriteLine($"Your number is " + text[i]);
}