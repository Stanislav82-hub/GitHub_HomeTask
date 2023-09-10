# Tекстовое описание решения задачи. #
## Условие задачи:
> Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
> *Примеры*:
**[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]**
>    **[“1234”, “1567”, “-2”, “computer science”] → [“-2”]**
>**“Russia”, “Denmark”, “Kazan”] → []**
***
## Решение задачи (Перейти по ссылке): 
1. Создаём метод по заполнению и выводу первичного массива, в котором:
   * Просим задать размерность массива
   * Запрашиваем ввести элементы массива
   * Выводим массив для наглядности
   ```C#
     string[] CreateAnitialArray()
        {
            Console.Write("How many elements AnitialArray should consist of?:\t");
            int AnitialArrayLenght = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string[] AnitialArray = new string[AnitialArrayLenght];
            for (int i = 0; i < AnitialArray.Length; i++)
            {
                Console.Write($"Please fill in {i + 1} element of AnitialArray :\t ");
                 AnitialArray[i] = Console.ReadLine();
            }
            Console.WriteLine();

            Console.WriteLine("AnitialArray consists of following elements:");
            for (int i = 0; i < AnitialArray.Length; i++)
            {
                Console.Write($"{AnitialArray[i]} | ");
            }
            Console.WriteLine();
            Console.WriteLine("========================================================================");
            return AnitialArray;
        }
    ```
2. Создаём метод по переносу подходящих элементов из первичного массива в заключительный массив, в котором:
   *   Проверяем количество элементов первичного массива соответствующих критериям задачи
   *   Если ни один элемент не подходит, то выводим об этом уведомление
   *   Создаём и заполняем массив равный по размерности результатам проверки и выводим его.
    ```C#
    void SecondArrayLength(string[] AnitialArray)
    {
        int n = 0;
        for (int i = 0; i < AnitialArray.Length; i++)
        {
            if (AnitialArray[i].Length <= 3)
            n++;
        }

        if (n < 1)
        {
            Console.WriteLine("There are no elements in AnitialArray to include in FinalArray");

        }
         else
        {
            Console.WriteLine();
            Console.WriteLine($"Length of FinalArray is {n} elements and they are following:");

            string[] FinalArray = new string[n];


          int j = 0;
          for (int i = 0; i < AnitialArray.Length; i++)
          {
            if (AnitialArray[i].Length <= 3)
             {
                 FinalArray[j] = AnitialArray[i];
                 j++;
             }
          }

            for (int i = 0; i < FinalArray.Length; i++)
            {
                Console.Write($" {FinalArray[i]} |");
            }
        }
    } 
3. Инициализируем программу
    ```c#
    SecondArrayLength(CreateAnitialArray());
    ```  
  ***
  ## Задача решена. ##



