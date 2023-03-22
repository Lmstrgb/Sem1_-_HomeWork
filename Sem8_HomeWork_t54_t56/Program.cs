// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int InputNum(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArrayInt(int m, int n)
{
  Console.WriteLine("Исходный, случайным образом сгенерированный массив");
  Random rand = new Random();
  int[,] arrayFunc = new int[m, n];
  for (int i = 0; i < arrayFunc.GetLength(0); i++)
  {
    for (int j = 0; j < arrayFunc.GetLength(1); j++)
    {
      arrayFunc[i, j] = rand.Next(0, 10);
      Console.Write(arrayFunc[i, j] + "\t");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
  return arrayFunc;
}

void SortRowsIn2DemArray(int[,] arrayInter)
{
  // пытался сделать одномерный массив из строк двумерного, 
  //но наткнулся на зубчатые массивы и попробовал использовать их
  int[][] ArrCollOfStr = new int[arrayInter.GetLength(0)][];

  for (int i = 0; i < arrayInter.GetLength(0); i++)
    ArrCollOfStr[i] = new int[arrayInter.GetLength(1)];


  //ArrCollOfStr[arrayInter.GetLength(0)] = new int[];
  for (int dem2 = 0; dem2 < arrayInter.GetLength(0); dem2++)
  {
    for (int dem1 = 0; dem1 < arrayInter.GetLength(1); dem1++)
    {
      ArrCollOfStr[dem2][dem1] = arrayInter[dem2, dem1];

    }
    Array.Sort(ArrCollOfStr[dem2]);
    Array.Reverse(ArrCollOfStr[dem2]);
  }

  Console.WriteLine("Строки массива отсортированы от большего значения элемента к меньшему");
  for (int dem2 = 0; dem2 < arrayInter.GetLength(0); dem2++)
  {
    for (int dem1 = 0; dem1 < arrayInter.GetLength(1); dem1++)
    {
      Console.Write(ArrCollOfStr[dem2][dem1] + "\t");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}

int[][] GenerateArrayOfArray(int[,] arrayInter)
{
  int[][] ArrCollOfStr = new int[arrayInter.GetLength(0)][];
  for (int i = 0; i < arrayInter.GetLength(0); i++)
    ArrCollOfStr[i] = new int[arrayInter.GetLength(1)];

  for (int dem2 = 0; dem2 < arrayInter.GetLength(0); dem2++)
  {
    for (int dem1 = 0; dem1 < arrayInter.GetLength(1); dem1++)
    {
      ArrCollOfStr[dem2][dem1] = arrayInter[dem2, dem1];
    }
  }

  return ArrCollOfStr;
}

void MinSummOfRowsArray(int[][] arrayJag)
{
  int sum = 0;
  int min = arrayJag[0].Sum();
  int minIndex = 0;
  for (int i = 0; i < arrayJag.Length; i++)
  {
    sum = arrayJag[i].Sum();
    minIndex = sum < min ? i : minIndex;
    min = sum < min ? sum : min;
  }
  Console.WriteLine($"Сумма элементов в строке № {minIndex}: [{String.Join(" ", arrayJag[minIndex])}] минимальна, и равна {min}.");
}

//Можно сделать поиск по массиву для поиска повторов минимальной суммы



int row = InputNum("Ввведите количество строк массива: ");
int col = InputNum("Введите количество столбцов массива: ");
Console.WriteLine();
int[,] arrayExt = GenerateArrayInt(row, col);
//SortRowsIn2DemArray(arrayExt); //Задача 54
int[][] arrayExtJag = GenerateArrayOfArray(arrayExt); // Задача 56
MinSummOfRowsArray(arrayExtJag);// Задача 56
