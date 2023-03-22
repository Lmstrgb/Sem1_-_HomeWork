// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

void MultTwoMatrix(int[,] matrix1intrnl, int[,] matrix2intrnl, int[,] matrix3intrnl)
{
  for (int i = 0; i < matrix1intrnl.GetLength(0); i++)
  {
    for (int j = 0; j < matrix2intrnl.GetLength(1); j++)
    {
      for (int k = 0; k < matrix1intrnl.GetLength(1); k++)
      {
        matrix3intrnl[i, j] += matrix1intrnl[i, k] * matrix2intrnl[k, j];
      }
    }
  }
}

void Print2DemArray(int[,] matrixIntrnl)
{
   Console.WriteLine("Перемноженный массив");
  for (int i = 0; i < matrixIntrnl.GetLength(0); i++)
  {
    for (int j = 0; j < matrixIntrnl.GetLength(1); j++)
    {
      Console.Write($"{matrixIntrnl[i, j]} \t");
    }
    Console.WriteLine();
  }
}


int row1 = InputNum("Ввведите количество строк массива 1: ");
int col1 = InputNum("Введите количество столбцов массива 1: ");
int[,] matrix1 = GenerateArrayInt(row1, col1);
Console.WriteLine();

int row2 = InputNum("Ввведите количество строк массива 2: ");
int col2 = InputNum("Введите количество столбцов массива 2: ");
int[,] matrix2 = GenerateArrayInt(row2, col2);
int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
  //int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
  MultTwoMatrix(matrix1, matrix2, matrix3);
}
else
{
  Console.WriteLine("Количество столбцов матрицы 1 должно быть равно количеству строк матрицы 2");
  Console.Write($"{Environment.NewLine}Press any key for exit....");
  Console.ReadKey(true);
  Environment.Exit(0); //чтобы исключение не лезло
}

Print2DemArray(matrix3);


