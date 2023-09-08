string[] AnitialArray = new string[5];

void StringArray(string[] AnitialArray)
{
  for (int i = 0; i < AnitialArray.Length; i++)
  {
    Console.Write($"Please fill in {i + 1} array element :\t ");
    AnitialArray[i] = Console.ReadLine();

  }
  Console.WriteLine();
  Console.WriteLine("Our array consists of following elements:");
  for (int i = 0; i < AnitialArray.Length; i++)
  {
    Console.Write($"{AnitialArray[i]} | ");
  }
}

void NewArrayLength(string[] AnitialArray)
{
  int n = 0;
  for (int i = 0; i < AnitialArray.Length; i++)
  {
    if (AnitialArray[i].Length <= 3)
      n++;
  }
  Console.WriteLine($"Length of second array is {n}");
  string[] FinalArray = new string[n];
  int j = 0;
  for (int i = 0; i < AnitialArray.Length; i++)
  {
    if (AnitialArray[i].Length <= 3)
      FinalArray[j] = AnitialArray[i];
      j++;
      Console.WriteLine($"{FinalArray[j]} |");
  }

}


StringArray(AnitialArray);
Console.WriteLine();
NewArrayLength(AnitialArray);
