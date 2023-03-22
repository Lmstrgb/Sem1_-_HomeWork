// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
//построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int InputNum(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}


int[] GenerateUniqArray1D(int[] array1DFunc)
{
  Random rand = new Random();
  for (int i = 0; i < array1DFunc.Length; i++)
  {
    int num = rand.Next(10, 101);
    if (array1DFunc.Contains(num))
    {
      i--;
    }
    else
    {
      array1DFunc[i] = num;
    }
  }
  Console.WriteLine($"Массив случайный уникальный: [{String.Join(" ", array1DFunc)}]");
  return array1DFunc;

}

int[,,] GenerateUniqArrayInt(int z, int m, int n, int[] array1DFunc)
{
  Console.WriteLine("Уникальный, случайным образом сгенерированный массив 3D");
  int count = 0;
  Random rand = new Random();
  int[,,] arrayFunc = new int[z, m, n];
  for (int k = 0; k < arrayFunc.GetLength(0); k++)
  {
    for (int i = 0; i < arrayFunc.GetLength(1); i++)
    {
      for (int j = 0; j < arrayFunc.GetLength(2); j++)
      {
        arrayFunc[k, i, j] = array1DFunc[count];
        Console.Write($"{arrayFunc[k, i, j]} [{k}, {i}, {j}] \t");
        count++;
      }
      //Console.WriteLine();
    }
    Console.WriteLine();
  }

  return arrayFunc;
}

int row = InputNum("Ввведите количество строк массива: ");
int col = InputNum("Введите количество столбцов массива: ");
int height = InputNum("Введите высоту трёмерного массива: ");
int[] array1D = new int[height * row * col];
array1D = GenerateUniqArray1D(array1D);
int[,,] matrix1 = GenerateUniqArrayInt(height, row, col, array1D);
Console.WriteLine();