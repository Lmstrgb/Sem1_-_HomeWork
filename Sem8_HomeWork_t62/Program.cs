// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int InputNum(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}

int[,] GetSpireInternet(int[,] array)
{
  var SizeX = array.GetUpperBound(0); //GetLength - 1
  var SizeY = array.GetUpperBound(1);
  var maxX = SizeX + 1;
  var maxY = SizeY;
  var dirX = 1;
  var dirY = 1;

  var x = -1;
  var y = 0;
  var val = 1;
  while ((maxX >= 0) && (maxY >= 0))
  {
    for (int xval = 1; xval <= maxX; xval++)
    {
      array[x + dirX * xval, y] = val;
      val++;
    }

    x = x + dirX * maxX;
    dirX = -dirX;
    maxX--;

    for (int yval = 1; yval <= maxY; yval++)
    {
      array[x, y + dirY * yval] = val;
      val++;
    }

    y = y + dirY * maxY;
    dirY = -dirY;
    maxY--;
  }

  return array;
}

int[,] GetSpireMy(int[,] array)
{
  int val = 1;
  for (int i = 0; i < 3; i++)
  {
    array[0, i] = val;
    val++;
  }
  for (int i = 0; i < 4; i++)
  {
    array[i, 3] = val;
    val++;
  }
  for (int i = 2; i >= 0; i--)
  {
    array[3, i] = val;
    val++;
  }
  for (int i = 2; i >= 1; i--)
  {
    array[i, 0] = val;
    val++;
  }
  for (int i = 1; i <= 2; i++)
  {
    array[1, i] = val;
    val++;
  }
  for (int i = 1; i <= 2; i++)//
  {
    array[i, 2] = val;
    val++;
  }
  array[2, 1] = val;
  return array;
}


void Print2DArray(int[,] matrixIntrnl)  // для спользования метода из интернета нужно поменять очередность вывода строк и столбцов
{
  Console.WriteLine("Спиральный массив");
  for (int i = 0; i < matrixIntrnl.GetLength(0); i++)
  {
    for (int j = 0; j < matrixIntrnl.GetLength(1); j++)
    {
      Console.Write($"{matrixIntrnl[i, j]} \t");
    }
    Console.WriteLine();
  }
}


int num = InputNum("Ввведите количество строк массива: ");
int[,] array2D = new int[num, num];
array2D = GetSpireMy(array2D); //GetSpireInternet(array2D); 
Print2DArray(array2D);

