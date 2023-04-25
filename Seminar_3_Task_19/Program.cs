// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

   Console.WriteLine("Hello, please fill in 5 digit number");

    int number = int.Parse(Console.ReadLine());

    string text = number.ToString();
    char[] textArray = text.ToCharArray();
    Array.Reverse(textArray);   //Изменяет порядок элементов в одномерном массиве Array на обратный.
    string finaltext = new string(textArray);
    int a = int.Parse(textArray);
    int b = int.Parse(finaltext);

    if(a == b)
    {
     Console.WriteLine("This is polendrome");
    }
    else
    {
     Console.WriteLine("This is not polendrome");
    }





    
/* bool Palindrom (string s)

{ for (int i = 0; i < s.Length / 2; i++)

 if (s[i] != s[s.Length - i - 1])
 {
 return false;
 }
 return true;
}

Console.WriteLine("введитепятизначное Число:");

int s = int.Parse (Console.ReadLine ());

string str = s.ToString();

Console.WriteLine (Palindrom (str)); */
