// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
      arrayFunc[i, j] = rand.Next(0, 4);
      Console.Write(arrayFunc[i, j] + "\t");
    }
    Console.WriteLine();
  }
  return arrayFunc;
}

double[] CreateArrOfAverageColumns(int[,] arrayFunc)
{
  int avr = 0;
  double[] mass = new double[arrayFunc.GetLength(1)];
  for (int j = 0; j < arrayFunc.GetLength(1); j++)
  {
    for (int i = 0; i < arrayFunc.GetLength(0); i++)
    {
      avr += arrayFunc[i, j];
    }
    mass[j] = (Convert.ToDouble(avr) / Convert.ToDouble(arrayFunc.GetLength(0)));
    avr=0;
    //avr =0;
  }
  return mass;
}


int row = InputNum("Ввведите количество строк массива: ");
int col = InputNum("Введите количество столбцов массива: ");
int[,] array = CreateArrayInt(row, col);
Console.WriteLine($"Среднее арифмитическое столбцов массива: {String.Join("; ", CreateArrOfAverageColumns(array))}");
