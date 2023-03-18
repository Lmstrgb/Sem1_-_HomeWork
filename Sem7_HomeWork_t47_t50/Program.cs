// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

double[,] CreateArrayDouble(int m, int n)
{
  Random rand = new Random();
  double[,] arrayFunc = new double[m, n];
  for (int i = 0; i < arrayFunc.GetLength(0); i++)
  {
    for (int j = 0; j < arrayFunc.GetLength(1); j++)
    {
      arrayFunc[i, j] = rand.Next(-10, 11) + rand.NextDouble();//new Random().NextDouble()*100;
      arrayFunc[i, j] = Math.Round(arrayFunc[i, j], 3);
      Console.Write(arrayFunc[i, j] + "\t");
    }
    Console.WriteLine();
  }
  return arrayFunc;
}

int InputNum(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArrayInt(int m, int n)
{
  Random rand = new Random();
  int[,] arrayFunc = new int[m, n];
  for (int i = 0; i < arrayFunc.GetLength(0); i++)
  {
    for (int j = 0; j < arrayFunc.GetLength(1); j++)
    {
      arrayFunc[i, j] = rand.Next(-3, 4); //+ rand.NextDouble();//new Random().NextDouble()*100;
                                          // arrayFunc[i, j] = Math.Round(arrayFunc[i, j], 3);
      Console.Write(arrayFunc[i, j] + "\t");
    }
    Console.WriteLine();
  }
  return arrayFunc;
}

void FindElemOfIntArray(int num, int[,] arrayFunc)
{
  string msg = String.Empty, pos = String.Empty;
  int count = 0;
  for (int i = 0; i < arrayFunc.GetLength(0); i++)
  {
    for (int j = 0; j < arrayFunc.GetLength(1); j++)
    {
      if (arrayFunc[i, j] == num)
      {
        pos += $" [{i},{j}]";
        msg = $"Позиции искомого числа {num} в массиве:" + $"{pos}";
        count++;
      }
      //else msg = $"Значения {num} нет в массиве";
      //el == num ? msg = $"Позиция искомого числа {num} в массиве:[{i},{j}]" : msg = $"Значения {num} нет в массиве";
      //Console.Write(msg);
    }
    //Console.WriteLine();
  }
  msg = count > 0 ? msg : $"Значения {num} нет в массиве";
  Console.WriteLine(msg);
}

int row = InputNum("Ввведите количество строк массива: ");
int col = InputNum("Введите количество столбцов массива: ");
int elem = InputNum("Введите искомое число: ");
Console.WriteLine();
//double[,] array = CreateArrayDouble(Row, Col); // Для задачи t47
int[,] array = CreateArrayInt(row, col);
Console.WriteLine();
FindElemOfIntArray(arrayFunc: array, num: elem);
Console.WriteLine();



